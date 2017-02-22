using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fire : MonoBehaviour {

	public Transform player;
	public Image heat;
	Color c;
	float dist;

	// Use this for initialization
	void Start () {
		c = heat.color;

	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (player.position, transform.position);

		if (dist < 8) {
			InvokeRepeating ("melt", 1.0f, 2.0f);
		} else {
			c.a = 0f;
			heat.color = c;
		}
	}

	void melt() {
		if (player.localScale.x > 1.0) {
			player.localScale -= new Vector3 (.2f, .2f, .2f);
		}
		c.a = .25f;
		heat.color = c;
		CancelInvoke ();
	}
}
