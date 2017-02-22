using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("q"))
			Application.Quit();
		else if (Input.GetKeyDown ("return"))
			SceneManager.LoadScene ("Level1");
	}
}
