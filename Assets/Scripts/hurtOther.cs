using UnityEngine;
using System.Collections;

public class hurtOther : MonoBehaviour {
	public int damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D other) {
		other.gameObject.GetComponent<health>().hurtMe(damage);
		if (other.gameObject.tag == "Player") {
			float hMod = other.gameObject.GetComponent<playerControllerMovement>().h;
			float vMod = other.gameObject.GetComponent<playerControllerMovement>().v;
			Vector3 direction = new Vector3(-hMod, -vMod, 0);
			other.gameObject.GetComponent<playerControllerMovement>().knockMeBack(direction);
		}  
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<health>().hurtMe(damage);
			float hMod = transform.parent.transform.parent.gameObject.GetComponent<playerControllerMovement>().h;
			float vMod = transform.parent.transform.parent.gameObject.GetComponent<playerControllerMovement>().v;
			Vector3 direction = new Vector3(hMod, vMod, 0);
			other.gameObject.GetComponent<enemyMotor>().knockMeBack(direction);
		}
	}
}
