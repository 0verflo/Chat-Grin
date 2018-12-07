using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Replay : MonoBehaviour {

	// Use this for initialization
	public Button replayButton;

	void Start () {
		//Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
		replayButton.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick () {
		//Output this to console when Button1 or Button3 is clicked
		SceneManager.LoadScene ("SampleScene");
	}
}