using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallSound : MonoBehaviour {
    public AudioSource source;
    public AudioClip dropSound;
    public AudioClip echoFloor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Terrain" && !source.isPlaying)
        {
		source.PlayOneShot (dropSound, 1f);
        }
        if(col.gameObject.name == "Sharft_Straight_Rails" && !source.isPlaying)
        {
		source.PlayOneShot (echoFloor, 1f);
        }
    }
}
