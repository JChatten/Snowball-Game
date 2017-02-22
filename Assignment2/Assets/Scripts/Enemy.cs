using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform player;
	public int moveSpeed = 6;
	public Tree tree;
	private Vector3 randomDirection;
	public Pause pause;

	// Use this for initialization
	void Start () {
		randomDirection = new Vector3 (0, Random.value, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (!tree.isHiding && !pause.pause) {
			
			transform.LookAt (player);
			if (player.localScale.x < transform.localScale.x) {
				moveForward ();
			} else {
				moveBack ();
			}
		} else if (!pause.pause) {
			transform.Rotate (randomDirection);
			moveForward ();
		} else {
			stayStill ();
		}
	}

	void moveForward() {
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}

	void moveBack() {
		transform.position -= transform.forward * moveSpeed * Time.deltaTime;
	}

	void stayStill() {
		player.position = player.position;
		transform.position = transform.position;
	}
}
