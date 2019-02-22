using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPurpleOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "keyPurple")
        {
		GameObject[] keyPurples = GameObject.FindGameObjectsWithTag("keyPurple");
			foreach(GameObject keyPurple in keyPurples)
			{
    	 	Destroy(keyPurple);
			}
        }
    }
}
