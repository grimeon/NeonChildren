using UnityEngine;
using System.Collections;

public class combineZoneController : MonoBehaviour {
	GameObject[] playerPos;
	int playersIn = 0;
	bool transformReady;
	bool combined = false;
	public GameObject dad;
	// Use this for initialization
	void Start () {
		playerPos = GameObject.FindGameObjectsWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 myPos = new Vector3 (0,0,0);
		foreach (GameObject playerT in playerPos) {
			myPos = myPos + playerT.transform.position;

		}


		myPos /= playerPos.Length;
		transform.position = myPos;

		if (playersIn == 4) {
			transformReady = true;	
		} else {
			transformReady = false;	
		}
		//print(playersIn);

		if(transformReady) {
			if (!combined && Input.GetAxis("player1_special") > 0 && Input.GetAxis("player2_special") > 0){
				combined = true;
				foreach (GameObject playerT in playerPos) {
					playerT.SetActive(false);
					dad.SetActive(true);
					dad.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				}
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			playersIn ++;
		}
		print("plareisIn");
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player"){
			playersIn = 0;
		}
	}
}
