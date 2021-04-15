using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTitle : MonoBehaviour
{
    private string sceneName;

    private void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Debug.LogFormat("{0} {1} {2}", "AAA", "BBB", "CCC");
        Debug.Log("1 Start:   sceneName=" + sceneName);
        Debug.Log($"2 Start:   sceneName={sceneName}");
        Debug.Log(string.Format("Format   sceneName={0}", sceneName));
        Debug.Log(10.ToString("X"));
        Debug.Log(String.Format("HEX={0:X}", 10));
        if(GetComponent<Text>() != null )
            GetComponent<Text>().text = sceneName;
        else
            Debug.Log("GetComponent<Text>() is null");
    }


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = sceneName;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
