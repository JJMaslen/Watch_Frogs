using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHacked : MonoBehaviour
{
	public void Flip()
	{
		transform.Rotate(0, 180, 0);
        //transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y + 180, gameObject.transform.rotation.z);
        PlayHackingSound.playHackingSound = true;
		Debug.Log("flipped");
	}
}
