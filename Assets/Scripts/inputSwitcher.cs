using UnityEngine;
using System.Collections;

public class inputSwitcher : MonoBehaviour {
	/*
	// Use this for initialization
	void Start () {
		 //controller axis on mac are different beasts with different axis
     if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer){
 
         if (Input.GetAxis("Mouse X") < -callibration || Input.GetAxis("Mouse X") > callibration ||
             Input.GetAxis("XboxMac X") < -callibration || Input.GetAxis("XboxMac X") > callibration)
 
             cursorX += (Input.GetAxis("Mouse X") + Input.GetAxis("XboxMac X")) * sensitivityX;
         
         if (Input.GetAxis("Mouse Y") < -callibration || Input.GetAxis("Mouse Y") > callibration ||
             Input.GetAxis("XboxMac Y") < -callibration || Input.GetAxis("XboxMac Y") > callibration)
 
             cursorY -= (Input.GetAxis("Mouse Y") + Input.GetAxis("XboxMac Y")) * sensitivityY;
     }
 
     else {
 
         if (Input.GetAxis("Mouse X") < -callibration || Input.GetAxis("Mouse X") > callibration)
             cursorX += Input.GetAxis("Mouse X") * sensitivityX;
         
         if (Input.GetAxis("Mouse Y") < -callibration || Input.GetAxis("Mouse Y") > callibration)
             cursorY -= Input.GetAxis("Mouse Y") * sensitivityY;
     }


	}
	*/
	
	// Update is called once per frame
	void Update () {
	
	}
}
