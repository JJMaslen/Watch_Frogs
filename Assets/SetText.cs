using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
	public Text text;
    // Start is called before the first frame update
    void Start()
    {
		text.text = PlayerPrefs.GetString("endText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
