using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public GameObject m_parentGO;
    // Start is called before the first frame update
    void Start()
    {
		// Debug.Log("this.name=" + this.name); // object name
		Utils.getScriptName(gameObject);
        Debug.Log("m_parentGO=" + m_parentGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
