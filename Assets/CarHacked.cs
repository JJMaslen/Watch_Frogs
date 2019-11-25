using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHacked : MonoBehaviour
{
	//public bool toggle = false;
	//public void Update()
	//{
	//	if (toggle)
	//	{
	//		flip();
	//	}
	//}
	public void Flip()
	{
		this.gameObject.transform.rotation = new Quaternion(this.gameObject.transform.rotation.x, 0f, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
		//toggle = !toggle;
	}
}
