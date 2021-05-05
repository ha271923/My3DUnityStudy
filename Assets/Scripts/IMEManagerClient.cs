using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMEManagerClient : MonoBehaviour
{
    GameObject m_EventSystemGO;
    IMEManagerServer m_IMEManagerServer;

    // Start is called before the first frame update
    void Start()
    {
        // IMEManagerServer.s_focusGO = gameObject;
        
        m_EventSystemGO = GameObject.Find("EventSystem");
		m_IMEManagerServer = m_EventSystemGO.GetComponent<IMEManagerServer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
