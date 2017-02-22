using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	public Transform player;
	float dist;
	public bool isHiding = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (player.position, transform.position);

		if (dist < 5) {
			isHiding = true;
		} else {
			isHiding = false;
		}
	}
}
