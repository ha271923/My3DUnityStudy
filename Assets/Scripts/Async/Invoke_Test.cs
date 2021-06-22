using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Test : MonoBehaviour
{
    private const int BALL_COUNT = 12;
    public GameObject target;
    private Vector3 pos = new Vector3(20, 2, 0);
    void Start()
    {
    
    }

    public void onClickButton_Invoke()
    {
        Debug.Log("onClickButton_Invoke");
        Debug.Log("Invoke + InvokeRepeating");
        this.InvokeRepeating("SpawnObject", 2.0f, 1.0f);
        this.Invoke("SpawnObject", 5);
    }

    void SpawnObject()
    {
        GameObject[] GOs = GameObject.FindGameObjectsWithTag("MySpawn");
        if (GOs.Length < BALL_COUNT)
        {
            pos.x = pos.x - 2;
            Instantiate(target, pos, Quaternion.identity);
        }
    }
    public void onClickButton_CancelInvoke()
    {
        Debug.Log("onClickButton_CancelInvoke");
        this.CancelInvoke();
    }

}
