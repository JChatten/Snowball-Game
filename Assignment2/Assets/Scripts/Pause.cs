using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool pause = true;
	public Text enter;
	GameObject[] enemies;
	GameObject player;
	GameObject boss;
	int aliveEnemies = 0;
	bool win = false;
	bool lose = false;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		player = GameObject.FindGameObjectWithTag ("Player");
		boss = GameObject.FindGameObjectWithTag ("Boss");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape"))
			PauseGame ();
		else if (Input.GetKeyDown ("q") && pause)
			Application.Quit();
		else if (Input.GetKeyDown ("return") && win)
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		else if (Input.GetKeyDown ("return") && lose || Input.GetKeyDown ("r") && pause) 
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
		else if (Input.GetKeyDown ("return"))
			BeginGame ();
		
		aliveEnemies = 0;
		for (int i = 0; i < enemies.Length; i++) {
			if (enemies [i] != null) {
				aliveEnemies++;
			}
		}
		if (aliveEnemies == 0 && boss == null) {
			Win ();
		} else if (player == null) {
			Lose ();
		}
	}

	void PauseGame() {
		enter.text = "Press R to restart \nPress Q to quit";
		pause = !pause;
	}

	void BeginGame() {
		pause = false;
		enter.text = "";
	}

	void Win() {
		enter.text = "You Win \nPress Enter to Continue";
		win = true;
	}

	void Lose() {
		enter.text = "You Lose \nPress Enter to try again";
		lose = true;
	}
}
