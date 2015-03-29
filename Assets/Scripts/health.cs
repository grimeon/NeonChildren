using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	//Starting health
	public int startHealth = 5;
	//current health that we don't set
	int currenthealth;
	//bool that checks if already hit
	bool invul = false;
	//timer
	float timer = 5.0f;
	public float coolDown = 5.0f;

	public GameObject light;


	// Use this for initialization
	void Start () {
		//initialize the health
		currenthealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.tag == "Player") {
		//timer goes down when invul
			if (invul){
				timer -= Time.deltaTime;
				gameObject.GetComponent<Animator>().SetBool("invul", true);
			} else {
				gameObject.GetComponent<Animator>().SetBool("invul", false);
			}
		
			//when time is up, reset invul
			if (timer <= 0) {
				invul = false;
			}

			light.GetComponent<Light>().intensity = currenthealth / 2;
			//killMe when dead
			
		}

		if (currenthealth <= 0) {
			
				gameObject.GetComponent<Animator>().SetTrigger("death");
				gameObject.GetComponent<enemyMotor>().isDead = true;
			}
	}

	//function called when collides with enemy
	public void hurtMe (int damage) {
		//if not invulnerable, subtract damage, make invulnerable
		if (!invul){
			//gameObject.GetComponent<playerController>().knockMeback(direction?);
			currenthealth -= damage;
			invul = true;
			//set timer to initial ammount
			timer = coolDown;
		}
	}

	//healing script, just in case
	public void healMe (int ammount) {
		//if not invulnerable, subtract damage, make invulnerable
		currenthealth += ammount;
		
	}
}
