﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarShot : MonoBehaviour {

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
        print("something within ear shot");
        }
	}
}
