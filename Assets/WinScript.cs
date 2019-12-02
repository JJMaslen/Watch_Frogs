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
        if (other.gameObject.tag == "Frog")
        {
            SceneManager.LoadScene(scenename, LoadSceneMode.Single);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Frog")
        {
            SceneManager.LoadScene(scenename, LoadSceneMode.Single);
        }
    }
}
