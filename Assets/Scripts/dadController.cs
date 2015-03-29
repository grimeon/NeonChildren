using UnityEngine;
using System.Collections;

public class dadController : MonoBehaviour {

	//Speed modifier
	public float speed = 5;
	//Kockback Modifier
	public float knockBack = 20;
	//horizontal input
	[HideInInspector]
	public float h;
	[HideInInspector]
	public float v;
	[HideInInspector]
	public float h2;
	[HideInInspector]
	public float v2;
	[HideInInspector]
	public float h3;
	[HideInInspector]
	public float v3;
	[HideInInspector]
	public float h4;
	[HideInInspector]
	public float v4;
	//The Player number for 
	//public string playerNum = "player1";

	//variables for the sprite flipper
	bool facingRight = true;
	bool lookingRight = true;

	public Transform sprite;

	//variable set when player dies
	public bool isDead;

	public bool p1Attacked = false;
	public bool p2Attacked = false;
	public bool p3Attacked = false;
	public bool p4Attacked = false;

	public GameObject[] bullets;
	public GameObject[] followPoints;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDead) {
		//Get the horizontal and vertical inputs
		//positive = 1, negative = -1, no input = 0;

		h = Input.GetAxisRaw("player1_h");
		v = Input.GetAxisRaw("player1_v");
		h2 = Input.GetAxisRaw("player2_h");
		v2 = Input.GetAxisRaw("player2_v");
		h3 = Input.GetAxisRaw("player3_h");
		v3 = Input.GetAxisRaw("player3_v");
		h4 = Input.GetAxisRaw("player4_h");
		v4 = Input.GetAxisRaw("player4_v");
		//add forces to the player based on these inputs
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h2 * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v2 * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h3 * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v3 * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h4 * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v4 * speed);
		//if moving, set animation bool
		if (h != 0 || v != 0) {
			gameObject.GetComponent<Animator>().SetBool("moving", true);
		} else {
			gameObject.GetComponent<Animator>().SetBool("moving", false);
		}
		
		//get attack button input, then set attack trigger
		if (Input.GetAxis("player1_attack") == 1 && p1Attacked == false){
			GameObject clone;
			clone = Instantiate(bullets[0], followPoints[0].transform.position, followPoints[0].transform.rotation) as GameObject;
			clone.GetComponent<hurtOther>().player = this.gameObject;
			p1Attacked = true;
		} else if (Input.GetAxis("player1_attack") == 0){
			p1Attacked = false;
		}

		if (Input.GetAxis("player2_attack") == 1 && p2Attacked == false){
			GameObject clone;
			clone = Instantiate(bullets[1], followPoints[1].transform.position, followPoints[0].transform.rotation) as GameObject;
			clone.GetComponent<hurtOther>().player = this.gameObject;
			p2Attacked = true;
		} else if (Input.GetAxis("player2_attack") == 0) {
			p2Attacked = false;
		}

		if (Input.GetAxis("player3_attack") == 1 && p3Attacked == false){
			GameObject clone;
			clone = Instantiate(bullets[2], followPoints[2].transform.position, followPoints[0].transform.rotation) as GameObject;
			clone.GetComponent<hurtOther>().player= this.gameObject;
			p3Attacked = true;
		} else if (Input.GetAxis("player3_attack") == 0) {
			p3Attacked = false;
		}

		if (Input.GetAxis("player4_attack") == 1 && p4Attacked == false){
			GameObject clone;
			clone = Instantiate(bullets[3], followPoints[3].transform.position, followPoints[0].transform.rotation) as GameObject;
			clone.GetComponent<hurtOther>().player = this.gameObject;
			p4Attacked = true;
		} else if (Input.GetAxis("player4_attack") == 0){
			p4Attacked = false;
		}


		flipMe(sprite);
		}
	}

	public void knockMeBack (Vector3 direction) {
		//add knockback force when called
		gameObject.GetComponent<Rigidbody2D>().AddForce(direction * knockBack);
	}

	void flipMe(Transform sprite) {

		if (h > 0) {
			lookingRight = false;
		} else {
			lookingRight = true;
		}
		//reverse scale 
		if ( lookingRight) {
			
			if (facingRight) {
				Vector3 theScale = sprite.localScale;
				theScale.x *= -1;
				sprite.localScale = theScale;
				facingRight = false;
			}
			
		} else {
			
			if (!facingRight) {
				Vector3 theScale = sprite.localScale;
				theScale.x *= -1;
				sprite.localScale = theScale;
				facingRight = true;
			}
			
		}
	}
}
