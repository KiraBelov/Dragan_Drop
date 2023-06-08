using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsladzejs : MonoBehaviour {
	public void uzNewScene()
	{
		SceneManager.LoadScene("New Scene", LoadSceneMode.Single);
	}

	public void uzPilsetasKarte()
	{
		SceneManager.LoadScene("PilsetasKarte", LoadSceneMode.Single);
	}

	public void Apturet()
	{
		Application.Quit();
	}
}
