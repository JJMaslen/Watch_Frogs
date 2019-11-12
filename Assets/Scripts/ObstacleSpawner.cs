using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obst;
    public Transform [] spawns;
    private bool nsc, call; //no spawnables catcher
    // Start is called before the first frame update
    void Start()
    {
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
            if (call)
            {
                StartCoroutine(Delay());
            }
        }
    }

    IEnumerator Delay()
    {
        call = false;
        yield return new WaitForSeconds(Random.Range(0.5f,1));
        Transform temp = spawns[Random.Range(0, spawns.Length)].transform;
        Instantiate(obst, temp.position, temp.rotation);
        call = true;
    }
}
