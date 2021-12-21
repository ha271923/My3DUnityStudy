using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MouseControl : MonoBehaviour
{
    public GameObject otherGameObject;
    int Val = 0;
    static int sVal = 0;

    // Start is called before the first frame update
    void Start()
	{
		Utils.getScriptName(gameObject);
	}

    private void OnMouseDown()
    {
		modify_data_of_otherGO();
		modify_data_of_other_GO_UIcomponent();
		modify_data_of_other_GO_Script(otherGameObject);
	}


	void modify_data_of_otherGO()
	{
		Val++;
		sVal++;

		GlobalScript globalScriptcomponent = otherGameObject.GetComponent<GlobalScript>();
		if (globalScriptcomponent != null)
		{
			globalScriptcomponent.Val += 1000;
			GlobalScript.sVal += 7000;
			Debug.Log("data GO name=" + transform.name + "   Script name=" + this.GetType() + "   sVal=" + sVal + "   Val=" + Val);
		}
	}

	void modify_data_of_other_GO_UIcomponent() {
		GameObject otherGO = GameObject.Find("TMP_Text");
		Debug.Log("UI otherGO=" + otherGO);
		TMP_Text tmp_Text = otherGO.GetComponent<TMP_Text>();
		Debug.Log("UI tmp_Text=" + tmp_Text);
		tmp_Text.text = "GO1 modified GO2's component";
		Debug.Log("UI inputField name=" + tmp_Text.transform.name + "   Script name=" + this.GetType());
	}

	void modify_data_of_other_GO_Script(GameObject otherGO) {
		DataScript1 script1 = otherGO.GetComponent<DataScript1>();
		script1.Val +=3000;
		DataScript1.sVal +=3000000;
		Debug.Log("script GO name=" + otherGO.transform.name + "   Script name=" + this.GetType() + "   Script1.sVal=" + sVal + "   script1.Val=" + Val);
	}

}
