using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {

	public float ThdTargetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float enemyMovementSpeed;
	public float damping;
	public Transform ThdTarget;
	Rigidbody theRigidbody;
	Renderer myRender;

	private UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		myRender = GetComponent<Renderer>();
		theRigidbody = GetComponent<Rigidbody>();
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		ThdTargetDistance = Vector3.Distance (ThdTarget.position, transform.position);
		if (ThdTargetDistance<enemyLookDistance){
			myRender.material.color=Color.blue;

			lookAtPlayer();
			print ("Look at player please");
		}
		if (ThdTargetDistance < attackDistance) {
			myRender.material.color=Color.red;
			attackPlease ();
			anim ();
			print ("Attack");
		}

		else {
			myRender.material.color=Color.blue;
			GetComponent<Animation>().Stop();
			print ("Look at player please");
		}
	}
	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation (ThdTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation,rotation, Time.deltaTime * damping);
	}
	void attackPlease(){
		theRigidbody.AddForce (transform.forward*enemyMovementSpeed);
	}

	void anim(){
		GetComponent<Animation>().Play("Run");

	}


}
