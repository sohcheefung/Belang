using UnityEngine;
using System.Collections;

public class lizardspawn : MonoBehaviour {
	public GameObject enemy;
	public float maxPos = 1346f;
	public float delayTimer = 9999999999999999999999999999999999f;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;

	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		if (timer <= -2) {

			Vector3 enemyPos = new Vector3 (Random.Range (1346f, 1349f), transform.position.y, (Random.Range (720f, 670f)));	
		
			Instantiate (enemy, enemyPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
