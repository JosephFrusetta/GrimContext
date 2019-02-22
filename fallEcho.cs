using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallEcho : MonoBehaviour {
    public AudioSource source;
    public AudioClip dropSound;
    
	// Use this for initialization
	void Start () 
	{
	AudioSource source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {	
	}
	 void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "floor")
        {
		source.PlayOneShot (dropSound, 1f);
        }
    }

}
