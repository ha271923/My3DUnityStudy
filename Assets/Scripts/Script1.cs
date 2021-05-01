using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public int Val = 0;
    public static int sVal = 0;
    // Start is called before the first frame update
    void Start()
    {
		Utils.getScriptName(gameObject);
	}

    private void OnMouseDown()
    {
		Utils.findParentGO(gameObject, "L1");
		Utils.findChildGO(gameObject, "L2.2");
		modify_data_in_current_GO();
	}

	void modify_data_in_current_GO() {
		Val++;
		sVal++;
		Debug.Log("GO name=" + transform.name + "   Script name=" + this.GetType() + "   sVal=" + sVal + "   Val=" + Val);
	}
}
