using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogLogFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Log")
		{
			this.gameObject.transform.parent = collision.gameObject.transform;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.tag == "Log")
		{
			this.gameObject.transform.parent = null;
		}
	}
}
