using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationPrefabScript : MonoBehaviour 
{
	public Animation placeAnimationHere;

	//for when object collides with trigger prefab
	void OnTriggerStay ()
	{
	placeAnimationHere.Play();
	GetComponent<Animation>();
	}
	
	//for when object leaves trigger prefab
	void OnTriggerExit ()
	{
	placeAnimationHere.Stop();
	}
}