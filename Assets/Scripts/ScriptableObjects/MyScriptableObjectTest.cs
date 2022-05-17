using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptableObjectTest : MonoBehaviour
{
    public MyScriptableObjectType1 myAttack;
    public MyScriptableObjectType2 myDefense;

    public MyScriptableObjectListDB1 allWeapons;
    public MyScriptableObjectListDB2 allArmors;


    void Start()
    {
        Debug.Log("myAttack.name=" + myAttack.name);
        Debug.Log("myDefense.name=" + myDefense.name);
    }

}
