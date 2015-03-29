using UnityEngine;
using System.Collections;

public class enemyMotor : MonoBehaviour {
//Speed modifier
	public float speed = 10;
	//Kockback Modifier
	public float knockBack = 20;

	//variables for the sprite flipper
	bool facingRight = true;
	bool lookingRight = true;

	//public Transform sprite;

	//variable set when player dies
	public bool isDead;

	public bool attacked = false;

	public bool moving = false;
	
	// Update is called once per frame
	void Update () {
		if (!isDead) {
		//if moving, set animation bool
			if (moving) {
			gameObject.GetComponent<Animator>().SetBool("moving", true);
			} else {
				gameObject.GetComponent<Animator>().SetBool("moving", false);
			}
		} else {
			gameObject.GetComponent<Animator>().SetTrigger("death");
		}
		
	}

	public void knockMeBack (Vector3 direction) {
		//add knockback force when called
		gameObject.GetComponent<Rigidbody2D>().AddForce(direction * knockBack);
	}

	void flipMe(Transform sprite) {
		/*
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
		*/
	}
}
