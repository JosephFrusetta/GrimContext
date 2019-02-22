using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyGreenOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {	
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "keyGreen")
        {
		GameObject[] keyGreens = GameObject.FindGameObjectsWithTag("keyGreen");
			foreach(GameObject keyGreen in keyGreens)
			{
    	 	Destroy(keyGreen);
			}
        }
    }
}