using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 upDir = new Vector3 (0,0,-1);
		transform.LookAt(target, upDir);

		transform.eulerAngles = new Vector3(0,0,-transform.eulerAngles.z);
		//add forces to the player based on these inputs

		//Aim player at mouse
		//which direction is up


	}
}
