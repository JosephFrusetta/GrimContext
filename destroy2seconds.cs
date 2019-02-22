using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2seconds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {	
	}

	void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "Camera (eye)")
        {
		StartCoroutine(wait());
        }
    }
	IEnumerator wait()
    {
	yield return new WaitForSeconds(4);
    Destroy(gameObject);        
    }
}
