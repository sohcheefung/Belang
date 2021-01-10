//==========================//
var playerH : Transform;
function OnTriggerEnter( other : Collider) 
{
    if (other.gameObject.tag== "Player") 
    {
    		 Debug.Log("Press E to pickup" );
   			transform.parent = playerH.transform;
   			transform.localPosition = Vector3(-0.61, 1.67, 2.51);
    		GetComponent.<Rigidbody>().isKinematic = true;
   	}


}
 
