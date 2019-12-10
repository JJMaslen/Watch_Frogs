using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obst;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (!nsc)
        {
            Instantiate(obst, this.gameObject.transform);
        }
    }
}
