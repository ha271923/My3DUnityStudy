using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyEventHanlderCenter : MonoBehaviour
{
    [SerializeField]
    public Text result0;
    public Text result1;
    public Text result2;
    public Text result3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onUpdateEventResult0() {
        Debug.Log("onUpdateEventResult0");
        int val = Int32.Parse(result0.text);
        val = val + 1;
        Debug.Log("onUpdateEventResult0  val="+val);
        result0.text = val.ToString();
    }
    public void onUpdateEventResult1()
    {
        Debug.Log("onUpdateEventResult1");

    }
    public void onUpdateEventResult2()
    {
        Debug.Log("onUpdateEventResult2");

    }
    public void onUpdateEventResult3()
    {
        Debug.Log("onUpdateEventResult3");

    }
}
