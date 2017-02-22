using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	GameObject[] Snowman;
	GameObject[] Enemies;
	public GameObject boss;
	int aliveEnemies = 0;
	bool battle = false;
	public AudioSource laugh;

	// Use this for initialization
	void Start () {
		Snowman =  GameObject.FindGameObjectsWithTag ("BossCollect");
		Enemies =  GameObject.FindGameObjectsWithTag ("Enemy");
		//boss = GameObject.FindGameObjectWithTag ("Boss");

		for (int i = 0; i < Snowman.Length; i++) {
			Snowman [i].SetActive (false);
		}
		//boss
	}
	
	// Update is called once per frame
	void Update () {
		print (boss == null);
		aliveEnemies = 0;
		for (int i = 0; i < Enemies.Length; i++) {
			if (Enemies [i] != null) {
				aliveEnemies++;
			}
		}
		if (aliveEnemies == 0 && !battle) {
			laugh.Play ();
			battle = true;
			boss.SetActive (true);
			boss.transform.position = new Vector3(-113, 10, -65);
			for (int i = 0; i < Snowman.Length; i++) {
				Snowman [i].SetActive (true);
			}
		}
	}
}
