using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public string scenename;//scene to load
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
		LoadScene(other.gameObject);
    }

 //   private void OnCollisionEnter(Collision collision)
 //   {
	//	LoadScene(collision.gameObject);

	//}

	private void LoadScene(GameObject coll)
	{
		if(coll.tag == "Frog")
		{
            print("LoadScene called");
			PlayerPrefs.SetString("endText", "Level Complete");
			SceneManager.LoadScene(scenename, LoadSceneMode.Single);
		}
	}
}
