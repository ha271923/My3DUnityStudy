using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Async
{
    class Callback_Test : MonoBehaviour
    {
        /*
         TestAPI +++
           callCB() call onFailed()
             TestAPI().onFailed()  longVal=1234567   strVal=Hawk
         TestAPI ---
         */

        public delegate void FailedCallback(long longVal, string strVal);  // #1 declaration func PTR

        public void TestAPI()
        {  // #2 entry
            Debug.Log("TestAPI +++");
            void onFailed(long longVal, string strVal) // #3 define CB
            {
                Debug.Log("TestAPI().onFailed()  longVal=" + longVal + "   strVal=" + strVal);  // #6 running CB
            }

            callCB(onFailed);  // #4 give a func PTR
            Debug.Log("TestAPI ---");
        }

        private void callCB(Action<long, string> onFailed)
        {
            Debug.Log("callCB() call onFailed()");

            onFailed(1234567, "Hawk");  // #5 calling CB by func PTR
        }

        private void Start()
        {
            TestAPI();
        }


    }
}
