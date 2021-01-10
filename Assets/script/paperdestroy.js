function OnTriggerEnter( other : Collider )
{
        	if (other.gameObject.tag == "paper")
        	{
           	  	Debug.Log("A paper was recycled");
           	  	Destroy(other.gameObject);
        	 }
        	 else
         	{
         		if (other.gameObject.tag != "paper")
         	{
            	Application.LoadLevel ("lose3");
         	}

      }
}