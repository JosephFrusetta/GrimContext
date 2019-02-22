using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFlicker : MonoBehaviour {
       
        public AudioSource source;
        public AudioClip spookySound;
        public Light light;
        private int lightStep = 1000;
        private bool firsttime = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {	
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.name == "Camera (eye)" && firsttime == true)
        {
        firsttime = false; 
        light.enabled = true;
        source.PlayOneShot (spookySound, 1f);
        }
	}
}
