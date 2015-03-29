using UnityEngine;
using System.Collections;

public class followPoint : MonoBehaviour {
	public Transform point;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = point.position;
	}
}
