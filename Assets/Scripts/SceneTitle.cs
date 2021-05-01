using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTitle : MonoBehaviour
{
    private string sceneName;

    private void Awake()
    {
        sceneName = Utils.getSceneName();
        Type type = gameObject.GetType();
        print("type="+ type);
        if (GetComponent<Text>() != null)
        {
            Debug.Log("GetComponent<Text>() is Text");
            GetComponent<Text>().text = sceneName;
            Debug.Log("GetComponent<Text>() is null");
        }
        else if (GetComponent<TextMeshProUGUI>() != null)  // 3D 物件 TextMeshPro 在Script裡面叫做 TextMeshProUGUI
        {
            Debug.Log("GetComponent<TextMeshProUGUI>() is TextMeshProUGUI");
            GetComponent<TextMeshProUGUI>().text = sceneName;
        }
        else
        {
            Debug.Log("GetComponent<Text or TextMeshPro>() are null");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Text>().text = sceneName;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
