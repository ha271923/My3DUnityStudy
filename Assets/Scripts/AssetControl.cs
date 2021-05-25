using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// My Asset STEP3. Use Asset in Game
public class AssetControl : MonoBehaviour
{
    AssetTest testConfig;
    string ConfigDir = "Assets/Editor/Resources/Config/";
    string ConfigFileName = "AssetTest.asset";
    // Use this for initialization
    public void LoadMyAsset()
    {
        this.testConfig = AssetDatabase.LoadAssetAtPath<AssetTest>(ConfigDir + ConfigFileName);
        print("testConfig.age ++:" + testConfig.age);
        this.testConfig.age = Random.Range(1, 100);
        print("testConfig.age --:" + testConfig.age);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
