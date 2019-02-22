using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionSound : MonoBehaviour 
{
	public AudioSource source;
    public AudioClip SoundOnce;
    private bool firsttime = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Camera (eye)" && firsttime == true)
		{
        firsttime = false; 
        source.PlayOneShot (SoundOnce, 3f);
		}
	} 
}
