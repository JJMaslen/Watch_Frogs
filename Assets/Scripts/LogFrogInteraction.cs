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
		tempParent = collision.gameObject.transform.parent;
		collision.gameObject.transform.parent = Log.transform;
	}

	private void OnCollisionExit(Collision collision)
	{
		collision.gameObject.transform.parent = tempParent;
	}
}
