using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDespawner : MonoBehaviour
{
	public string target = "Car";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == target)
        {
            Destroy(other.gameObject);
        }
    }
}