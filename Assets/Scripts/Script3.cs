using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
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
			Debug.Log("GO name=" + transform.name + "   Script name=" + this.GetType() + "   sVal=" + sVal + "   Val=" + Val);
		}
	}

}
