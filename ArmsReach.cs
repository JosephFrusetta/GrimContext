using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsReach : MonoBehaviour {

        public AudioSource source;
        public AudioClip spookySound;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.name == "test2")
        {
        print("something within arms reach");
       	source.PlayOneShot (spookySound, 1f);
		gameObject.GetComponent<Light>().intensity += lightStep * Time.deltaTime;
		iTween.MoveBy(gameObject, iTween.Hash("z", -2, "easeType", "easeInOutExpo", "delay", 1));
        }
	}
}
