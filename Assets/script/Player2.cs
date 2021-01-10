using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	[SerializeField]
	private Stat health;

	[SerializeField]
	private GameObject EnemyCollider;


	// Use this for initialization
	private void Awake()
	{
		health.Initialize ();
	}

	void OnCollisionEnter(Collision _collision)
	{
		if (_collision.gameObject.tag == "enemy") {
			health.CurrentVal -= 10;
		}

		else if (health.CurrentVal <= 0 )
		{
			Application.LoadLevel ("lose3");
		}
	}
}
