using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGOs
{

    public class Script1 : MonoBehaviour
    {
        private GlobalScript global;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("this=" + this);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void API_1()
        {
            Debug.LogError("Script1 API_1");
            global.API_1();
        }
    }
}
