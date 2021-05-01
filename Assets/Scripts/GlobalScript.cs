using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
	public int Val = 0;
	public static int sVal = 0;

	// Start is called before the first frame update
	void Start()
	{
		Utils.getScriptName(gameObject);
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
