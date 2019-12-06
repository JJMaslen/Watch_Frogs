using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverStateChecker : MonoBehaviour
{
	public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (player.GetComponent<FrogMovement>().lives == -1)
		{
			PlayerPrefs.SetString("endText", "Game Over");
			SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
		}
    }
}
