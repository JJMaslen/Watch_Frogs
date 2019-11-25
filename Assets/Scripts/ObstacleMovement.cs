using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10.0f;
	public Vector3 currentspeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		currentspeed = (transform.forward * speed) * -1;
		rb.velocity = (transform.forward * speed) * -1;
    }
}
