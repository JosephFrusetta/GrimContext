using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCollision : MonoBehaviour 
{
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "playerCollisionObject")
		{
		GetComponent<Animation>().Play("animationTriggerAnimation");
		}
	}
}
