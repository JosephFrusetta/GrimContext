using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollision : MonoBehaviour 
{
	public	GameObject	particlePrefab;

	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "playerCollisionObject")
		{
		StartCoroutine (AudioCoroutine());
		}
	}

	IEnumerator AudioCoroutine ()
	{
	GameObject audioObject = (GameObject) Instantiate (particlePrefab, this.transform.position, this.transform.rotation);
	yield return new WaitForSeconds (1);
	}
}