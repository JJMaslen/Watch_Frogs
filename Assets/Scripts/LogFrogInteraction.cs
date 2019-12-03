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

		}
	}

	//private void OnCollisionExit(Collision collision)
	//{
	//	print("Exit");
	//	collision.gameObject.transform.parent = null;
	//}
}