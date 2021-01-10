using UnityEngine;
using System.Collections;

public class lizardspawn1 : MonoBehaviour {
	public GameObject enemy;
	public float maxPos = 255f;
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

			Vector3 enemyPos = new Vector3 (Random.Range (255f, 236f), transform.position.y, transform.position.z);	

			Instantiate (enemy, enemyPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
