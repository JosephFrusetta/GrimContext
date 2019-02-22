using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerExit : MonoBehaviour {

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {	
	}

    void OnTriggerExit (Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
        Destroy(gameObject);
        }
    }
}