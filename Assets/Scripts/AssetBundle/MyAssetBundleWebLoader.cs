using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class MyAssetBundleWebLoader : MonoBehaviour
{
    public string bundleUrl = "https://drive.google.com/u/0/uc?id=1XE06AkaMKP-JJzph5h54FGBF6wlgf8fm&export=download";
    public string assetName = "BundledObject";

    // Start is called before the first frame update
    IEnumerator Start()
    {
        using (WWW web = new WWW(bundleUrl))
        {
            yield return web;
            AssetBundle remoteAssetBundle = web.assetBundle;
            if (remoteAssetBundle == null)
            {
                Debug.LogError("Failed to download AssetBundle!");
                yield break;
            }
            Instantiate(remoteAssetBundle.LoadAsset(assetName));
            remoteAssetBundle.Unload(false);
        }
    }


}