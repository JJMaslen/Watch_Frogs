using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obst;
    public Transform [] spawns;
    private bool nsc; //no spawnables catcher
    // Start is called before the first frame update
    void Start()
    {
        if (obst == null)
        {
            nsc = true;
        }
        else
        {
            nsc = false;
        }

        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            spawns[i] = this.gameObject.transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!nsc)
        {
            Instantiate(obst, spawns[Random.Range(0, spawns.Length)]);
        }
    }
}
