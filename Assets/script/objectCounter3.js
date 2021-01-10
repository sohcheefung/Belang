	 var Paper : int = 0;
     var paperToWin : int = 30;		//number to win!
    
     function OnTriggerEnter( other : Collider )
      {
        	if (other.gameObject.tag == "paper")
        	{
           	  	Paper += 1;
           	  	Debug.Log("A paper was picked up. Total papers = " + Paper);
           	  	Destroy(other.gameObject);
        	 }

      }
	 
     function OnGUI()
     {
         if (Paper < paperToWin)
         {
             
         }
         else
         {
            Application.LoadLevel ("win3");
         }
     }