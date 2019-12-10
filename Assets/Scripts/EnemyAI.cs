using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Frog;

    public Vector3 targetPosition;
    public Quaternion targetRotation;

	public bool IsActive;

    AudioSource audioFrogIdle;

    void Start()
    {
        targetPosition = transform.position;

        StartCoroutine("MoveX");
        audioFrogIdle = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.4f);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.4f);
    }

    private void FixedUpdate()
    {
        float idleSound = Random.Range(0.0f, 1.0f);
        if (idleSound > 0.9995)
        {
            audioFrogIdle.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
	}

	IEnumerator MoveX()
    {
		if (IsActive)
		{
			if (targetPosition.x > Frog.transform.position.x)
			{
				targetPosition -= new Vector3(2.0f, 0, 0);
				targetRotation = Quaternion.Euler(0, 90, 0);
			}
			else
			{
				targetPosition += new Vector3(2.0f, 0, 0);
				targetRotation = Quaternion.Euler(0, -90, 0);
			}
		}
		yield return new WaitForSeconds(0.5f);
		StartCoroutine("MoveZ");
    }

    IEnumerator MoveZ()
    {
		if (IsActive)
		{
			if (targetPosition.z > Frog.transform.position.z)
			{
				targetPosition -= new Vector3(0.0f, 0.0f, 2.0f);
				targetRotation = Quaternion.Euler(0, 0, 0);
			}
			else
			{
				targetPosition += new Vector3(0.0f, 0.0f, 2.0f);
				targetRotation = Quaternion.Euler(0, 180, 0);
			}
		}

		yield return new WaitForSeconds(0.5f);
		StartCoroutine("MoveX");
    }


}
