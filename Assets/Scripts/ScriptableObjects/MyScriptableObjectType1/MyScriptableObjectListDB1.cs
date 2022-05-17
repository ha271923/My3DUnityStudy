using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=0nW5PhQTWbQ&list=PLfvYL9lU6oPjNwzA1sNLnRYfm3b7ZYjuk&index=58
[CreateAssetMenu(fileName = "myScriptableObjectListDB1", menuName = "Create My ScritableObjectDB/MyScriptableObjectDB1")]
public class MyScriptableObjectListDB1 : ScriptableObject
{
    public List<MyScriptableObjectType1> myWeaponObjectList;
    private void OnValidate() // This function is called when the script is loaded or a value is changed in the Inspector (Called in the editor only).
    {
        Debug.Log("OnValidate");
    }

    private void Awake() // This function is called when the ScriptableObject script is started.
    {
        Debug.Log("Awake");
    }
    private void OnEnable() // This function is called when the object is loaded.
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable() // This function is called when the scriptable object goes out of scope.
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy() // This function is called when the scriptable object will be destroyed.
    {
        Debug.Log("OnDestroy");
    }
}
