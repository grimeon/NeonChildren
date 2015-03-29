using UnityEngine;
using System.Collections;

public class playerControllerMovement : MonoBehaviour {

	//Speed modifier
	public float speed = 10;
	//Kockback Modifier
	public float knockBack = 20;
	//horizontal input
	[HideInInspector]
	public float h;
	//Vertical Input
	[HideInInspector]
	public float v;
	//The Player number for 
	public string playerNum = "player1";
	bool facingRight = true;
	bool lookingRight = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Get the horizontal and vertical inputs
		//positive = 1, negative = -1, no input = 0;
		h = Input.GetAxis(playerNum + "_h");
		v = Input.GetAxis(playerNum + "_v");
		//add forces to the player based on these inputs
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v * speed);
		//if moving, set animation bool
		if (h !=0 || v != 0) {
			gameObject.GetComponent<Animator>().SetBool("moving", true);
		} else {
			gameObject.GetComponent<Animator>().SetBool("moving", false);
		}
		//get attack button input, then set attack trigger
		if (Input.GetButtonDown(playerNum + "_attack")){
			gameObject.GetComponent<Animator>().SetTrigger("attack");
		}


		//flipMe();

	}

	public void knockMeBack (Vector3 direction) {
		//add knockback force when called
		gameObject.GetComponent<Rigidbody2D>().AddForce(direction * knockBack);
	}

	void flipMe() {

		if (h > 0) {
			lookingRight = false;
		} else {
			lookingRight = true;
		}
		//reverse scale 
		if ( lookingRight) {
			
			if (facingRight) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				facingRight = false;
			}
			
		} else {
			
			if (!facingRight) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				facingRight = true;
			}
			
		}
	}
}
