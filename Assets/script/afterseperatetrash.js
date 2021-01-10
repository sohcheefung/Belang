var rubbish : int = 0;
     var rubbishToWin : int = 14;

function OnTriggerEnter( other : Collider )
{

		if (other.gameObject.tag == "rubbish")
        	{
        		rubbish += 1;
        		Destroy(other.gameObject);
        	} else
        	if (rubbish < rubbishToWin)
         {
            Application.LoadLevel ("winner");
         }
 }
        





