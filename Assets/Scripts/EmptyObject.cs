using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyObject : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("HAWK   objectName=" + transform.name);
		if (gameObject.transform.parent != null) {
			var parentGameObject = gameObject.transform.parent.gameObject;
			// Debug.Log("HAWK   parentGameObject=" + parentGameObject); // =L1 (UnityEngine.GameObject)
			if (parentGameObject != null) // =L1
				Debug.Log("HAWK   parentGameObject.transform.name=" + parentGameObject.transform.name);
		}

		var childCount = transform.childCount;
		if (childCount != 0) {
			for (int i = 0; i < childCount; i++) {
				if (transform.GetChild(i).gameObject.transform.name == "L2.2")
				{
					Debug.Log("HAWK   found childGO L2.2 !!!!!!");
				}
			}

		}
	
	}
}
