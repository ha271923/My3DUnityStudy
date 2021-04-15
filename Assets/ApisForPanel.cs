using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApisForPanel : MonoBehaviour
{
    public void loadScene(string sceneName) {
        Debug.Log($"loadScene   {sceneName} +++");
        SceneManager.LoadScene(sceneName);
        Debug.Log($"loadScene   {sceneName} ---");
    }
}
