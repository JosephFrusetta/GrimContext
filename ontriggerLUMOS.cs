using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriggerLUMOS : MonoBehaviour {

    public AudioSource source;
    public AudioClip spookySound;
    private int lightStep = 400;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {	
	}

	void onTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "Camera (eye)")
        {
       	source.PlayOneShot (spookySound, 5f);
		gameObject.GetComponent<Light>().intensity += lightStep * Time.deltaTime;
		iTween.MoveBy(gameObject, iTween.Hash("z", -2, "easeType", "easeInOutExpo", "delay", 1));
        }
    }
}