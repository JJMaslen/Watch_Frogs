using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHacking : MonoBehaviour
{
	public GameObject arrowObj;
	public float MinimumDistance = 5.0f;

	GameObject targetCar;
	public GameObject empty;

    void Start()
    {
        
    }

    void Update()
    {
		var cars = GameObject.FindGameObjectsWithTag("Car");

		foreach(var car in cars)
		{
			float dist = Vector3.Distance(car.transform.position, transform.position);

			if (dist < MinimumDistance)
			{
				//car.transform.position + new Vector3(0, 4, 0) +
				arrowObj.transform.position = car.transform.position + new Vector3(0, 3, 0);
				targetCar = car;

				if (targetCar == null)
				{
					arrowObj.transform.position = new Vector3(999, 999, 999);
				}
			}
		}

		if (targetCar == null)
		{
			arrowObj.transform.position = new Vector3(999, 999, 999);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			targetCar.GetComponent<CarHacked>().Flip();
		}

	}
}