using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
	public bool spawncaprand = false;
    public GameObject [] obst;
    public Transform [] spawns;
    private bool nsc, call; //no spawnables catcher
	public int spawncap = 0;
	public bool limitless = true;
	//int spawncount = 0;
	public bool aschild = false;
	public Vector3 offset;
	public float delmax = 2;
	public float delmin = 0.5f;
	// Start is called before the first frame update
	void Start()
    {
		if (spawncaprand)
		{
			spawncap = Random.Range(0, 2);
		}

        call = true;
        int temp = 0;
        foreach (GameObject item in obst)
        {
            if (item == null)
            {
                continue;
            }
            else
            {
                temp++;
            }
        }

        if (temp != obst.Length)
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
		float secs = Random.Range(delmin, delmax);
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
			Instantiate(obst[Random.Range(0,obst.Length)], temp);
		}
		else
		{
			Instantiate(obst[Random.Range(0, obst.Length)], temp.position, temp.rotation);
		}
        call = true;
    }
}
