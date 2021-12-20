using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.IO;

public class MyAssetBundleLocalLoader : MonoBehaviour
{
    public string bundleUrl = "local/file/aaaa";
    public string assetName = "BundledObject";

    private void Start()
    {
        string fileName = "fooAssetBundle";//name of the assetbundle you want to load

        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, fileName));//Creates a filepath starting at the streamingAssetsPath and appends filename to it. 

        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("MyObject");//Create a GameObject from the assetbundle
        Instantiate(prefab);//instantiate the GameObject

        myLoadedAssetBundle.Unload(false);//Unload the assetbundle from memory as it isn't used anymore
    }


}