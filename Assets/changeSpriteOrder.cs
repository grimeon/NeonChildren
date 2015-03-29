using UnityEngine;
using System.Collections;

public class changeSpriteOrder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis(transform.parent.transform.parent.GetComponent<playerControllerMovement>().playerNum + "_v");
		if (v > 0){
			gameObject.GetComponent<SpriteRenderer>().sortingOrder = -1;
		} else {
			gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
		}

	}
}
