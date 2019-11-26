using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogFrogInteraction : MonoBehaviour
{
	public GameObject Log;

	Transform tempParent;

	// Start is called before the first frame update
	void Start()
	{
		
	}
    

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Frog")
		{
			print("Enter");
			//tempParent = collision.gameObject.transform.parent;
			collision.gameObject.transform.parent = this.gameObject.transform;// Log.transform;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		print("Exit");
		collision.gameObject.transform.parent = null;
	}
}