using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoroutine_Test : MonoBehaviour
{
    static int i;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StartCoroutine_Test Start" + Time.time);


    }

    public void onClickButton_StartCoroutine()
    {
        Debug.Log("onClickButton_StartCoroutine");
        Debug.Log("StartCoroutine"); 
        StartCoroutine(CoroutineTest());
    }
    IEnumerator CoroutineTest()
    {
        while (i < 100)
        {
            Debug.Log("i=" + i + "   CoroutineTest ++ At" + Time.time);
            yield return new WaitForSeconds(1f);
            Debug.Log("i=" + i + "   CoroutineTest -- At" + Time.time);
            i++;
        }
    }
}

