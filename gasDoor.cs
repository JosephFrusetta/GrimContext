using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasDoor : MonoBehaviour {

public GameObject NeoDemoObject;
private NeoDemo NeoDemoScript;
private bool booleanScriptTwo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		NeoDemoScript = NeoDemoObject.GetComponent<NeoDemo>();
		booleanScriptTwo = NeoDemoScript.unlockedGas;
		if (booleanScriptTwo == true)
		{
		Destroy(gameObject);
		}
	}
}
