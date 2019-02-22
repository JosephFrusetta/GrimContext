using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOnTouch : MonoBehaviour {

	public GameObject thing;
    private Rigidbody rb;
    private int firstRun = 0;

	// Use this for initialization
	void Start () 
	{
	rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "ArmsReach")
		{
		thing.GetComponent<Rigidbody>().useGravity = false;
 			if (firstRun == 0)
			{
			thing.GetComponent<Rigidbody>().velocity = transform.up * 0.1f;
			rb.AddTorque(transform.forward * -0.2F);
			firstRun = 1;
			}
		}
	}	

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.name == "EarShot")
		{
		thing.GetComponent<Rigidbody>().useGravity = true;
		}
	}		
}
