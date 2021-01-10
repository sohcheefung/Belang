function OnTriggerEnter( other : Collider )
{
        	if (other.gameObject.tag == "metal")
        	{
           	  	Debug.Log("A metal was recycled");
           	  	Destroy(other.gameObject);
        	 }
        	 else
         	{
         		if (other.gameObject.tag != "metal")
         	{
            	Application.LoadLevel ("lose3");
         	}

      }
}