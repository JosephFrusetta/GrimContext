using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBreak : MonoBehaviour {
    public AudioSource source;
    public AudioClip breakSound;

	// Use this for initialization
	void Start () 
	{
	AudioSource source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	
	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Shaft_Split_Track" || col.gameObject.name == "Sharft_Straight_Rails" || col.gameObject.name == "Sharft_Straight_Open" ||
        col.gameObject.name == "Track_Split")
        {
		source.PlayOneShot (breakSound, 1f);
		Destroy(gameObject);
		}
    }
}
