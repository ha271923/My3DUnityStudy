using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDebugLogs : MonoBehaviour
{
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
