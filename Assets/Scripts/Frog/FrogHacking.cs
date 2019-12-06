using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogHacking : MonoBehaviour
{
	public GameObject arrowObj;
	public float MinimumDistance = 5.0f;

	GameObject targetCar;
	public GameObject empty;

	public int MaxHackingUses = 5;
	public int HackingUses = 5;

	public Text text;

    void Start()
    {
        
    }

    void Update()
    {
		text.text = HackingUses + "/" + MaxHackingUses;
			
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
			if (HackingUses > 0)
			{
				targetCar.GetComponent<CarHacked>().Flip();
				HackingUses -= 1;

				var enemies = GameObject.FindGameObjectsWithTag("Enemy");

				foreach (var enemy in enemies)
				{
					float dist = Vector3.Distance(enemy.transform.position, transform.position);

					if (dist < 15.0f)
					{
						enemy.GetComponent<EnemyAI>().IsActive = true;
					}
				}
			}

		}

	}
}