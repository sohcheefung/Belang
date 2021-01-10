using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void BtnNext()
	{
		Application.LoadLevel ("page2");
	}

	public void BtnSkip()
	{
		Application.LoadLevel ("stage");
	}

	public void BtnNext1()
	{
		Application.LoadLevel ("stage");
	}

	public void BtnMenu()
	{
		Application.LoadLevel ("menu");
	}

	public void BtnSkip1()
	{
		Application.LoadLevel ("winner");
	}

	public void BtnNext2()
	{
		Application.LoadLevel ("page4");
	}
}
