using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGOs;

public class ShowDebugLogs : MonoBehaviour
{
    Script1 script1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Log");
        Debug.LogWarning("LogWarning");
        Debug.LogError("LogError");
        print("print");
    }

    public void onClick_debugLog() {
        Debug.Log("Log");
        Debug.LogWarning("LogWarning");
        Debug.LogError("LogError");
        print("print");
        script1.API_1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
