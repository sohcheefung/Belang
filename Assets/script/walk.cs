using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			MoveRight ();
	
	}
}
	void MoveRight(){
		Vector3 position = transform.position;
		position.x += speed;
		transform.position = position;

	}
}