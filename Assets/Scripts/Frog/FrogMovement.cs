using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
	[Range(1, 5)]
	public float MovementAmount = 1.0f;

	public float MovementSpeed = 0.1f;

	public float RotationSpeed = 0.1f;

	private Vector3 targetPosition;
	private Quaternion targetRotation;


	private Transform parent;
    void Start()
    {
		targetPosition = transform.position;
		targetRotation = transform.rotation;
    }

    void Update()
    {
		transform.position = Vector3.Lerp(transform.position, targetPosition, MovementSpeed);
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, RotationSpeed);

		if (Input.GetKeyDown(KeyCode.S))
		{
			targetPosition += new Vector3(-MovementAmount, 0, 0);
			targetRotation = Quaternion.Euler(0, 90, 0);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			targetPosition += new Vector3(MovementAmount, 0, 0);
			targetRotation = Quaternion.Euler(0, -90, 0);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			targetPosition += new Vector3(0, 0, -MovementAmount);
			targetRotation = Quaternion.Euler(0, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			targetPosition += new Vector3(0, 0, MovementAmount);
			targetRotation = Quaternion.Euler(0, 180, 0);
		}
		
		//if (parent != null && this.gameObject.transform.IsChildOf(parent))
		//{
		//	targetPosition = this.gameObject.transform.position;
		//}
	}

    private void OnCollisionEnter(Collision other)
    {
		if (other.gameObject.tag == "Log")
		{
			parent = other.gameObject.transform;
		}

        if (other.gameObject.tag == "Car")
        {
			targetPosition = new Vector3(0.3081f, 0.322f, 13.247f);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.tag == "Log")
		{
			parent = null;
		}
	}
}
