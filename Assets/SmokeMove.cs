using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeMove : MonoBehaviour {

	private Transform transform;

	// Use this for initialization
	void Awake () {
		transform = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x + 0.1f, 5, 0);
	}
}