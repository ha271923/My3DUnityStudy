using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGOs
{

    public class Script4 : MonoBehaviour
    {
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
            Debug.LogError("this=" + this + "    Script1 API_1");
        }
    }
}
