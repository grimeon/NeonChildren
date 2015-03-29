using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {
	public float force = 50;
	public Quaternion dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * force);
	}
}
