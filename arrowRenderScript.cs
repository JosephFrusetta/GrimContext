using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowRenderScript : MonoBehaviour 
{
	public GameObject arrowGroup;
	// Use this for initialization
	void Start () 
	{
	GetComponent <GameObject>();
	}

	void OnTriggerEnter(Collider other) 
	{
	if (other.gameObject.CompareTag("pipeCollision"))
	arrowGroup.SetActive(true);
	}
}