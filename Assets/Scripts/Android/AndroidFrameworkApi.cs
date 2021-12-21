using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidFrameworkApi : MonoBehaviour
{
    string DateTimeText;

    public void triggerVibration()
    {
        Debug.Log("triggerVibration +++");
        // Handheld.Vibrate();
        Debug.Log("triggerVibration ---");
    }

    public void triggerVibration1()
    {
        Debug.Log("triggerVibration 1");
    }

    public void setDateTo(int MM, int DD, int YYYY) {
        DateTime dateTime = DateTime.Now;
    }

}
