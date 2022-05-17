using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=0nW5PhQTWbQ&list=PLfvYL9lU6oPjNwzA1sNLnRYfm3b7ZYjuk&index=58
[CreateAssetMenu(fileName = "myScriptableObjectListDB2", menuName = "Create My ScritableObjectDB/MyScriptableObjectDB2")]
public class MyScriptableObjectListDB2 : ScriptableObject
{
    public List<MyScriptableObjectType2> myArmorObjectList;

    private void OnValidate()
    {
        Debug.Log("OnValidate");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
