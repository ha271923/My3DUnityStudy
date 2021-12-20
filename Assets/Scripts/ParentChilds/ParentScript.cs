using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ParentScript : MonoBehaviour, IPointerClickHandler
{
    int childCount;
    GameObject[] childGameObjects;

    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!");
        childGameObjects = getChildObjects();
    }

    public GameObject[] getChildObjects() {
        GameObject[] ret = new GameObject[10];
        childCount = gameObject.transform.childCount;

        Debug.Log("childCount=" + childCount);
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                Debug.Log("gameObject=" + gameObject);
                Transform tf = gameObject.transform.GetChild(i);
                if (tf == null)
                    Debug.Log("tf == null");
                var go = gameObject.transform.GetChild(i).gameObject;
                ret[i] = go;
            }
        }
        return ret;
    }
}
