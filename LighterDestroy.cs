using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name.Contains("Lighter")||other.gameObject.name.Contains("Torch"))
        {
        Destroy(gameObject);
        }
    }
}
