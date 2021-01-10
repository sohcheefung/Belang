function OnTriggerEnter( other : Collider )
{
        	if (other.gameObject.tag == "plastic")
        	{
           	  	Debug.Log("A plastic was recycled");
           	  	Destroy(other.gameObject);
        	 }
        	 else
         	{
         		if (other.gameObject.tag != "plastic")
         	{
            	Application.LoadLevel ("lose3");
         	}

      }
}