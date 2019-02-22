using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour {
        public AudioSource source;
        public AudioClip nomnom;
        public AudioClip dropSound;
        public Transform crumbs; 
        private float lifetime; 

	// Use this for initialization
	void Start () 
	{
    AudioSource source = GetComponent<AudioSource>();
    crumbs.GetComponent<ParticleSystem> ().enableEmission = false; 
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "Camera (eye)")
        {
        print("Player ate something yummy");
		source.PlayOneShot (nomnom, 2f);
		crumbs.GetComponent<ParticleSystem> ().enableEmission = true; 
		Destroy(gameObject, lifetime);
        }
    }

 void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "floor")
        {
        print("Object hit the floor");
		source.PlayOneShot (dropSound, 1f);
        }
    }
}
