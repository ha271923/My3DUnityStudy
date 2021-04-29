using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public GameObject L2Parent;
    // Start is called before the first frame update
    void Start()
    {
		// Debug.Log("this.name=" + this.name); // object name
		Debug.Log("this.GetType()=" + this.GetType()); // script name
        // Debug.Log("this.GetType().Name=" + this.GetType().Name); // script name
        L2Parent.SetActive(true);
        Debug.Log("L2Parent=" + L2Parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
