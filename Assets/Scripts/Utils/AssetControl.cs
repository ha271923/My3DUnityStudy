using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// My Asset STEP3. Use Asset in Game
public class AssetControl
{
    AssetTest testConfig;
    string ConfigDir = "Assets/Editor/Resources/Config/";
    string ConfigFileName = "AssetTest.asset";
    // Use this for initialization
    public void LoadMyAsset()
    {
#if UNITY_EDITOR
        this.testConfig = AssetDatabase.LoadAssetAtPath<AssetTest>(ConfigDir + ConfigFileName);
        Debug.Log("testConfig.age ++:" + testConfig.age);
        this.testConfig.age = Random.Range(1, 100);
        Debug.Log("testConfig.age --:" + testConfig.age);
#endif
    }

}
