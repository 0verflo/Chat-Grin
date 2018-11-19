using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBoundaries : MonoBehaviour {

	public Vector2 minimumBoundary = new Vector2(2.0f, 6.0f);
	public Vector2 maximumBoundary = new Vector2(10.0f, 12.0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	transform.position = new Vector3
	(
		Mathf.Clamp (transform.position.x, minimumBoundary.x, maximumBoundary.x),
		Mathf.Clamp (transform.position.y, minimumBoundary.y, maximumBoundary.y),
		transform.position.z
	);

	}
}
