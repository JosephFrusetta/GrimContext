namespace VRTK.Examples
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventHelper;

public class ButtonReactorDestroyKP : MonoBehaviour {

        private VRTK_Button_UnityEvents buttonEvents;

        private void Start()
        {
            buttonEvents = GetComponent<VRTK_Button_UnityEvents>();
            if (buttonEvents == null)
            {
            buttonEvents = gameObject.AddComponent<VRTK_Button_UnityEvents>();
            }
            buttonEvents.OnPushed.AddListener(handlePush);
        }

        private void handlePush(object sender, Control3DEventArgs e)
        {
		GameObject[] keyPurples = GameObject.FindGameObjectsWithTag("keyPurple");
			foreach(GameObject keyPurple in keyPurples)
			{
    	 	Destroy(keyPurple);
			}
        }
    }
}