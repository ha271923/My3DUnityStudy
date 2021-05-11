using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMEKeyBallController : MonoBehaviour
{
    GameObject m_VirtualKeyboardManagerGO;
    MeshRenderer m_IMEKeyBallMeshRender;
    IMEManagerServer m_IMEManagerServer;
    // Start is called before the first frame update
    void Start()
    {
        m_IMEKeyBallMeshRender = GetComponent<MeshRenderer>();

        m_VirtualKeyboardManagerGO = GameObject.Find("VirtualKeyboardManager");
        m_IMEManagerServer = m_VirtualKeyboardManagerGO.GetComponent<IMEManagerServer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        m_IMEManagerServer.onClickKeyBall("A");
    }

    public bool isActive(){
        return m_IMEKeyBallMeshRender.enabled;
    }

    public void show(){
        m_IMEKeyBallMeshRender.enabled = true;
    }

    public void hide(){
        m_IMEKeyBallMeshRender.enabled = false;
    }

    public void OnSelected()
    {
        Debug.Log("OnSelected() +");
    }

    public void OnDeselect()
    {
        Debug.Log("OnDeselect() -");
    }

}
