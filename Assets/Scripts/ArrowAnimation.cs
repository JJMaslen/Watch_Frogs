using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimation : MonoBehaviour
{
	public GameObject Arrow;
	Vector3 currentPosition;

	float bob;
	float rotate;
	// Start is called before the first frame update
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		bob = (Mathf.Sin(Time.fixedTime) / 100);
		rotate += 1;

		currentPosition = Arrow.transform.position;
		Arrow.transform.position = new Vector3(currentPosition.x, currentPosition.y + bob, currentPosition.z);
		Arrow.transform.rotation = Quaternion.Euler(-90, rotate, 0);
    }
}