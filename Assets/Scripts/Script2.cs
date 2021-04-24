using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		// Debug.Log("this.name=" + this.name); // object name
		Debug.Log("this.GetType()=" + this.GetType()); // script name
		// Debug.Log("this.GetType().Name=" + this.GetType().Name); // script name
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
