#pragma strict

var sound : AudioClip;

function Start () {

}

function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("coin"))
	{
		GetComponent.<AudioSource>().PlayOneShot(sound);
	}
}