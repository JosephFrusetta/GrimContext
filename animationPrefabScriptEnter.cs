using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationPrefabScriptEnter : MonoBehaviour 
{
	public Animation placeAnimationHere;

	//for when object collides with trigger prefab
	void OnTriggerEnter ()
	{
	GetComponent<Animation>();
	placeAnimationHere.Play();
	}
}