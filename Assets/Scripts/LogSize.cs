using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSize : MonoBehaviour
{
	public GameObject obst;
	public Transform[] spawns;
	// Start is called before the first frame update
	void Start()
    {
		int rn = Random.Range(2, 5);
		this.gameObject.transform.localScale = new Vector3(rn,1,1);
		//this.gameObject.GetComponent<BoxCollider>().size = new Vector3(rn, 1, 1);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
