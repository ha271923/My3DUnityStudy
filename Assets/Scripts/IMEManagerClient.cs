using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMEManagerClient : MonoBehaviour
{
    GameObject m_VirtualKeyboardManagerGO;
    IMEManagerServer m_IMEManagerServer;

    // Start is called before the first frame update
    void Start()
    {
        // IMEManagerServer.s_focusGO = gameObject;

        m_VirtualKeyboardManagerGO = GameObject.Find("VirtualKeyboardManager");
		m_IMEManagerServer = m_VirtualKeyboardManagerGO.GetComponent<IMEManagerServer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelect() // addListener() by Inspector UI
    {
        Debug.Log("IMEManagerClient::onSelect()");
    }

    public void OnDeselect() // addListener() by Inspector UI
    {
        Debug.Log("IMEManagerClient::onDeselect()");
    }

}
