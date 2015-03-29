using UnityEngine;
using System.Collections;

public class detectOtherPlayers : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		//if collider is a player and is not me
//		if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<playerController>().playerNum != this.transform.parent.gameObject.GetComponent<playerController>().playerNum){
			//function for morphing characters
//		}
	}
}
