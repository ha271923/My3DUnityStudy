using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMEKeyBallController : MonoBehaviour
{
    GameObject m_IMEKeyBall;

    // Start is called before the first frame update
    void Start()
    {
        m_IMEKeyBall = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isActive(){
        if (gameObject.active)
            return true;
        else
            return false;
    }

    public void show(){
        m_IMEKeyBall.SetActive(true);
    }

    public void hide(){
        m_IMEKeyBall.SetActive(false);
    }


}
