using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public void Exit()
	{
		Application.Quit();
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}

	public void Restart()
	{
		SceneManager.LoadScene("FinalLevel", LoadSceneMode.Single);
	}
}
