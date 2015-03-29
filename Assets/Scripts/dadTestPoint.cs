using UnityEngine;
using System.Collections;

public class dadTestPoint : MonoBehaviour {
	public string playerNum;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis(playerNum + "_h2");
		float v = Input.GetAxis(playerNum + "_v2");

		if (h != 0 ){
			transform.position = new Vector3 (transform.parent.transform.position.x + h, transform.position.y, transform.position.z);
		}

		if (v != 0 ){
			transform.position = new Vector3 (transform.position.x, transform.parent.transform.position.y + v, transform.position.z);
		}
	}
}
