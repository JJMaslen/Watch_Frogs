using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogFrogInteraction : MonoBehaviour
{
	public GameObject Log;
	public GameObject Frog;

	Transform tempParent;

	public bool frogIsOnLog = false;

	void Start()
	{
		
	}
    
    void FixedUpdate()
    {

	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Frog")
		{
			Frog = collision.collider.gameObject;

			Frog.transform.parent = transform;
			Frog.GetComponent<Rigidbody>().isKinematic = true;
			Frog.GetComponent<FrogMovement>().shouldMove = false;
		}
	}

	//private void OnCollisionExit(Collision collision)
	//{
	//	print("Exit");
	//	collision.gameObject.transform.parent = null;
	//}
}