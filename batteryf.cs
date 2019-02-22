using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryf : MonoBehaviour 
{
	public float batteryPower;

	void start (){
	}

	public void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Flashlight"))
		{
		Destroy(gameObject);
		}
	}
}
