﻿using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	//Starting health
	public int startHealth = 5;
	//current health that we don't set
	int currenthealth;
	//bool that checks if already hit
	bool invul = false;
	//timer
	float timer;
	public float coolDown = 5.0f;
	// Use this for initialization
	void Start () {
		//initialize the health
		currenthealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
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

		//killMe when dead

	}

	//function called when collides with enemy
	void hurtMe (int damage) {
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
	void healMe (int ammount) {
		//if not invulnerable, subtract damage, make invulnerable
		currenthealth += ammount;
		
	}
}
