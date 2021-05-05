using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IMEManagerServer : MonoBehaviour
{
	IMEManagerServer sInstance;
	GameObject m_IMEKeyBall;
	IMEKeyBallController m_IMEKeyBallController;
    static public GameObject s_focusGO;
    private TMP_InputField m_InputField;

    // Start is called before the first frame update
    void Start()
    {
        m_IMEKeyBall = GameObject.Find("IMEKeyBall");
		m_IMEKeyBallController = m_IMEKeyBall.GetComponent<IMEKeyBallController>();
    }

	public IMEManagerServer getInstance(){
		return this;
	}

	public void setFocusGO(GameObject GO){
		s_focusGO = GO;
	}


	private TMP_InputField GetInputField()
	{
		Debug.Log( "GetInputField() +++");
		if (s_focusGO != null)
		{
			TMP_InputField inputObj = s_focusGO.GetComponent<TMP_InputField>();
			Debug.Log( "this=" + this);
			Debug.Log( "s_InputGameObject=" + s_focusGO);
			Debug.Log( "s_InputGameObject.transform.name:" + s_focusGO.transform.name);
			return inputObj;
		}
		else
		{
			Debug.LogError("m_InputGameObject == null");
			throw new System.NullReferenceException();
		}
		return null;
	}

    private void OnMouseDown()
    {
		m_InputField = GetInputField();

        m_InputField.text += "A";
        // m_InputField.placeholder.text = "ppppp";
        // m_InputField.textComponent.text = "TMP_Text";


	}

	public void showKeyBall(){
		m_IMEKeyBallController.show();
	}

	public void hideKeyBall(){
		m_IMEKeyBallController.hide();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

