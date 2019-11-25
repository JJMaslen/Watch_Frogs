﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
	public bool spawncaprand = false;
    public GameObject obst;
    public Transform [] spawns;
    private bool nsc, call; //no spawnables catcher
	public int spawncap = 0;
	public bool limitless = true;
	//int spawncount = 0;
	public bool aschild = false;
	public Vector3 offset;
	// Start is called before the first frame update
	void Start()
    {
		if (spawncaprand)
		{
			spawncap = Random.Range(0, 1);
		}

        call = true;
        if (obst == null)
        {
            nsc = true;
        }
        else
        {
            nsc = false;
        }

        //for (int i = 0; i < ; i++)
        //{
        //    spawns[i] = this.gameObject.transform.GetChild(i);
        //}
    }

    // Update is called once per frame
    void Update()
    {
		
        if (!nsc)
        {
			if (limitless)
			{
				if (call)
				{
					StartCoroutine(Delay());
				}
			}
			else
			{
				if (spawncap > 0)
				{
					for (int i = 0; i < spawncap; i++)
					{
						if (call)
						{
							StartCoroutine(Delay());
							spawncap--;
						}

					}
				}
			}
		}
    }

    IEnumerator Delay()
    {
        call = false;
		float secs = Random.Range(0.5f, 2);
		if (spawncaprand)
		{
			yield return new WaitForSeconds(0);
		}
		else
		{
			yield return new WaitForSeconds(secs);
		}

		Transform temp;
		if (spawns.Length > 1)
		{
			temp = spawns[Random.Range(0, spawns.Length)].transform;
		}
		else
		{
			temp = spawns[0].transform;
		}
		
		if (aschild)
		{
			Instantiate(obst, temp);
		}
		else
		{
			Instantiate(obst, temp.position, temp.rotation);
		}
        call = true;
    }
}
