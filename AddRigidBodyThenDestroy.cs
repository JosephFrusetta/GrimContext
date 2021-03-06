﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidBodyThenDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(wait());
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	IEnumerator wait()
    {
	yield return new WaitForSeconds(20);
    gameObject.GetComponent<Rigidbody>().useGravity = true ;
	yield return new WaitForSeconds(10);
    Destroy(gameObject);
    }
}
