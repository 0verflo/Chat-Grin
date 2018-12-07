using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmokeMove : MonoBehaviour {

	private Transform transform;
	private bool shouldMove = true;

	// Use this for initialization
	void Awake () {
		transform = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (shouldMove)
			transform.position = new Vector3 (transform.position.x + 0.1f, 5, 0);
	}

	private void stopSmoke () {
		shouldMove = false;
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene (SceneManager.GetSceneAt (0).name);
		} else if (other.tag == "LevelClear") {
			SceneManager.LoadScene("Level1EndScreen");
		}

		if (other.tag == "EndTrigger") {
			Debug.Log ("test");
			stopSmoke ();
		}
	}
}