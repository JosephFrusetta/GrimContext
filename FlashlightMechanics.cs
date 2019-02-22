namespace VRTK.Examples
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMechanics : VRTK_InteractableObject 
{
   	public AudioClip toggleSound;
    public AudioClip backpacked;
    public AudioClip feltInventory;
    public AudioClip insert;
   	public Light myLight;
    public GameObject Flashlight;
    public GameObject Backpack;
    public  AudioSource source;
    private float batteryLifeInSeconds = 1f;
   	private float batteryLife;
   	private bool isActive;
    private FixedJoint joint;
    private bool inventory = false;
   	private VRTK_ControllerReference controllerReference;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
		batteryLife = myLight.intensity;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if  (isActive == true)
		{
		myLight.intensity -= batteryLife / batteryLifeInSeconds * Time.deltaTime;
		}
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Battery"))
        {
        AddBatteryLife(1);
        source.PlayOneShot (insert, 4f);
        }

        //Insert Backpack
        if(other.gameObject.name == "Backpack" && inventory == false)
        {
        source.PlayOneShot (backpacked, 1f);
        joint = Flashlight.gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = Backpack.GetComponent<Rigidbody>();
        inventory = true;   
        }

        if(other.gameObject.name == "CustomHandCollider" && inventory == true && !source.isPlaying)
        {
        source.PlayOneShot (feltInventory, 1f);
        }
    }

	public override void StartUsing(VRTK_InteractUse usingObject)
    {
    	Haptic();
    	source.PlayOneShot(toggleSound, 1f);
    	if  (batteryLifeInSeconds > 1)
    	{
    		myLight.enabled = true;
    		isActive = true;
    	}
    	if (batteryLifeInSeconds == 0)
    	{
    		myLight.enabled = false;
    	}
    }

    public override void StopUsing(VRTK_InteractUse usingObject)
    {
    Haptic();
    source.PlayOneShot(toggleSound, 1f);
    base.StopUsing(usingObject);
    myLight.enabled = false;
    isActive = false;
    }

	void Haptic () 
	{
    VRTK_ControllerHaptics.TriggerHapticPulse(controllerReference, 1f, 1f, 220f);
	}

	public override void Grabbed(VRTK_InteractGrab grabbingObject)
    {
    base.Grabbed(grabbingObject);
    controllerReference = VRTK_ControllerReference.GetControllerReference(grabbingObject.controllerEvents.gameObject);
    Destroy(joint);    
        //Remove Backpack
        if(inventory == true)
        {
        Destroy(joint); //two destory joints prevents multiple joints from building up?
        StartCoroutine("stickyness");
        }

        if(inventory == true && !source.isPlaying)
        {
        source.PlayOneShot (backpacked, 1f);
        }
    }

    IEnumerator stickyness()
    {
    yield return new WaitForSeconds(3);
    inventory = false; 
    }

    public void AddBatteryLife(float _batteryPower)
    {
    myLight.intensity += _batteryPower;
    	if (myLight.intensity > batteryLifeInSeconds)
    		myLight.intensity = batteryLifeInSeconds;
    }
}
}
