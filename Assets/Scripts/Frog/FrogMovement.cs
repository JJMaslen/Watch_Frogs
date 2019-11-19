using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
	[Range(1, 5)]
	public float MovementAmount = 1.0f;

	public float MovementSpeed = 0.1f;

	private Vector3 targetPosition;

    void Start()
    {
		targetPosition = transform.position;
    }

    void Update()
    {
		transform.position = Vector3.Lerp(transform.position, targetPosition, MovementSpeed);

        if (Input.GetKeyDown(KeyCode.W))
		{
			targetPosition += new Vector3(-MovementAmount, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			targetPosition += new Vector3(MovementAmount, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			targetPosition += new Vector3(0, 0, -MovementAmount);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			targetPosition += new Vector3(0, 0, MovementAmount);
		}
	}
}
