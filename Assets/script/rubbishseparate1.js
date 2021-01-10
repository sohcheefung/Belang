	 var Paper : int = 0;
     var paperToWin : int = 30;		//number to win!
    
     function OnTriggerEnter( other : Collider )
      {
        	if (other.gameObject.tag == "rubbish")
        	{
           	  	Paper += 1;

        	 }

      }
	 
     function OnGUI()
     {
         if (Paper < paperToWin)
         {
             
         }
         else
         {
            Application.LoadLevel ("page3");
         }
     }