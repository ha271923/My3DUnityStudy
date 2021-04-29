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
		Debug.Log("this.GetType()=" + this.GetType()); // script name
	}

    private void OnMouseDown()
    {
        Val++;
        sVal++;
        Debug.Log("GO name=" + transform.name + "   Script name=" + this.GetType() + "   sVal=" + sVal + "   Val=" + Val);
    }
}
