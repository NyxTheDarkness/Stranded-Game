using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Start_Script : MonoBehaviour {

	public void LoadScene()
	{
		Debug.Log("Loading First Scene");
		SceneManager.LoadScene("first", LoadSceneMode.Single);
	}
}
