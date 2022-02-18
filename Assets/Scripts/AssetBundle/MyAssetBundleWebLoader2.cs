using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.Events;
using System;

public class MyAssetBundleWebLoader2 : MonoBehaviour
{
    public Transform m_bundleParent;
    public string BundleFolder = "https://drive.google.com/u/0/uc?id=1XE06AkaMKP-JJzph5h54FGBF6wlgf8fm&export=download";
    void Start()
    {
        
    }

    public void onClickButton() {
        GetBundleObject("xxxx", null, m_bundleParent);
    }

    public void GetBundleObject(string assetName, UnityAction<GameObject> callback, Transform bundleParent)
    {
        StartCoroutine(GetAssetBundle(assetName, callback, bundleParent));
    }

    IEnumerator GetAssetBundle(string assetName, UnityAction<GameObject> callback, Transform bundleParent)
    {
        // string bundleURL = BundleFolder + assetName + "-";
        string bundleURL = BundleFolder;
/*
        //append platform to asset bundle name
#if UNITY_ANDROID
        bundleURL += "Android";
#else
        bundleURL += "IOS";
#endif
*/
        Debug.Log("Requesting bundle at " + bundleURL);

        //request asset bundle
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(bundleURL);
        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            Debug.Log("Network error");
        }
        else
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            if (bundle != null)
            {
                string rootAssetPath = bundle.GetAllAssetNames()[0];
                GameObject arObject = null;
                try
                {
                    arObject = Instantiate(bundle.LoadAsset(rootAssetPath) as GameObject, bundleParent); // if AB is prefab already
                }
                catch (Exception e) {
                    Debug.LogError("e=" + e);
                }
                bundle.Unload(false);
                if(callback != null)
                    callback(arObject);
            }
            else
            {
                Debug.Log("Not a valid asset bundle");
            }
        }
    }
}