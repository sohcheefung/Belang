using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingBarScript : MonoBehaviour {

	AsyncOperation ao;
	public GameObject LoadingScreenBG;
	public Slider ProgBar;
	public Text LoadingText;

	public bool isFakeLoadingBar = false;
	public float fakeIncrement = 0f;
	public float fakeTiming = 0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel01()
	{
		LoadingScreenBG.SetActive (true);
		ProgBar.gameObject.SetActive (true);
		LoadingText.gameObject.SetActive (true);
		LoadingText.text = "Loading...";

		if (!isFakeLoadingBar) 
		{
			StartCoroutine (LoadLevelWithRealProgress ());
		} 

		else 
		{


		}

	}

	IEnumerator LoadLevelWithRealProgress()
	{
		yield return new WaitForSeconds (1);

		ao = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (4);
		ao.allowSceneActivation = false;

		while (!ao.isDone) 
		{
			ProgBar.value = ao.progress;

			if(ao.progress == 0.9f) 
			{
				ProgBar.value = 1f;
				LoadingText.text = "Press 'F' To Continue";
				if (Input.GetKeyDown (KeyCode.F)) {
					ao.allowSceneActivation = true;
				}
			}

			Debug.Log (ao.progress);
			yield return null;
		}
		
	}
}
