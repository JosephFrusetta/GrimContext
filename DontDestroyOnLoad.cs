﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void Awake () 
    {
    DontDestroyOnLoad (gameObject);
    }
}
