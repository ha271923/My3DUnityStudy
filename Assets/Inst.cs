using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sceneName = "HHHHHHHHHHHHHH";
        Debug.LogFormat("{0} {1} {2}", "AAA", "BBB", "CCC");
        Debug.Log("1 Start:   " + sceneName);
        Debug.Log($"2 Start:  {sceneName}");
        Debug.Log(string.Format("Format   {0}", sceneName));
        Debug.Log(10.ToString("X"));
        Debug.Log(String.Format("HEX={0:X}", 10));
        print("<color=red>這樣能輸出紅色訊息</color>");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
