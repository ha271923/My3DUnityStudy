using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyTimeControl : MonoBehaviour
{
    TMP_InputField m_InputField;
    string m_Time;

    void Start()
    {
        m_InputField = GetComponent<TMP_InputField>();

    }

    // Update is called once per frame
    void Update()
    {
        m_Time = m_InputField.text;



    }


    void getCurrentTime() {
        // try to get the launch date saved as a string:
        string savedDate  = PlayerPrefs.GetString("LaunchDate", "");
        if (savedDate == "")
        { // if not saved yet...
          // convert current date to string...
            savedDate = DateTime.Now.ToString();
            // and save it in PlayerPrefs as LaunchDate:
            PlayerPrefs.SetString("LaunchDate", savedDate);
        }
        // at this point, the string savedDate contains the launch date
        // let's convert it to DateTime:
        DateTime launchDate;
        DateTime.TryParse(savedDate, out launchDate);
        // get current DateTime:
        DateTime now = DateTime.Now;
        // calculate days ellapsed since launch date:
        long days = (now - launchDate).Days;
        print("Days since first launch:" + days);

    }


    private static DateTime selectedDate = DateTime.Now;

    class DateCallback : AndroidJavaProxy
    {
        public DateCallback() : base("android.app.DatePickerDialog$OnDateSetListener") { }
        void onDateSet(AndroidJavaObject view, int year, int monthOfYear, int dayOfMonth)
        {
            selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
        }
    }

    public void showDatePicker()
    {
        Debug.Log("DATE="+string.Format("{0:yyyy-MM-dd}", selectedDate));
        var activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
        {
            new AndroidJavaObject("android.app.DatePickerDialog", activity, new DateCallback(), selectedDate.Year, selectedDate.Month - 1, selectedDate.Day).Call("show");
        }));
    }
}
