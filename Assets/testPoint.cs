using UnityEngine;
using System.Collections;

public class testPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis(transform.parent.GetComponent<playerControllerMovement>().playerNum + "_h");
		float v = Input.GetAxis(transform.parent.GetComponent<playerControllerMovement>().playerNum + "_v");

		if (h != 0 ){
			transform.position = new Vector3 (transform.parent.transform.position.x + h, transform.position.y, transform.position.z);
		}

		if (v != 0 ){
			transform.position = new Vector3 (transform.position.x, transform.parent.transform.position.y + v, transform.position.z);
		}
	}
}
