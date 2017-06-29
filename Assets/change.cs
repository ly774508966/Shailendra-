using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour {

	// Use this for initialization
	public void changescene(string changetoscene)
	{
		SceneManager.LoadScene(changetoscene);
	}
}
