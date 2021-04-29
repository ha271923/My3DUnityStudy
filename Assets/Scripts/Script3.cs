using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public GameObject sharedGameObject;
    int Val = 0;
    static int sVal = 0;

    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("this.GetType()=" + this.GetType()); // script name
	}

    private void OnMouseDown()
    {
        Val++;
        sVal++;

        if (sharedGameObject != null)
        {
            Script1 script1component = sharedGameObject.GetComponent<Script1>();
            if (script1component != null )
            {
                script1component.Val += 1000;
                Script1.sVal += 7000;
                Debug.Log("GO name=" + transform.name + "   Script name=" + this.GetType() + "   sVal=" + sVal + "   Val=" + Val);
            }
        }
    }

}
