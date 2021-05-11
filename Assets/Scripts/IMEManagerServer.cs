using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;

public class IMEManagerServer : MonoBehaviour
{
	IMEManagerServer sInstance;
	GameObject m_IMEKeyBall;
	IMEKeyBallController m_IMEKeyBallController;
    static public GameObject s_focusGO;
    private TMP_InputField m_InputField;
	private string mInputContent = null;
	private StringBuilder onInputClickedSB;


	public void onClickKeyBall(string strKey) {
		onInputClickedSB.Append(strKey);
		mInputContent = onInputClickedSB.ToString();
	}
    // Start is called before the first frame update
    void Start()
    {
        m_IMEKeyBall = GameObject.Find("IMEKeyBall");
		m_IMEKeyBallController = m_IMEKeyBall.GetComponent<IMEKeyBallController>();
    }

	public IMEManagerServer getInstance(){
		return this;
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

	private void UpdateInputField(string str)
	{
		if (m_InputField != null && str != null)
		{
			m_InputField.text = str;
		}
	}

	public void showKeyBall(GameObject GO){
		s_focusGO = GO;
		m_InputField = GetInputField();
		onInputClickedSB = new StringBuilder("XXXX");
		m_IMEKeyBallController.show();
	}

	public void hideKeyBall(){
		m_IMEKeyBallController.hide();
		m_InputField = null;
		onInputClickedSB = null;
		s_focusGO = null;
	}

    // Update is called once per frame
    void Update()
    {
		if (mInputContent != null) {
			UpdateInputField(mInputContent);
		}
		mInputContent = null;
	}
}

