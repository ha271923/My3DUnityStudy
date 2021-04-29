using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnumChildGOs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		printChildGOs();

	}

	private void printChildGOs() {
		var childCount = transform.childCount;
		if (childCount != 0) {
			for (int i = 0; i<childCount; i++) {
				Debug.Log("transform.GetChild("+i+").gameObject.transform.name=" +
					transform.GetChild(i).gameObject.transform.name);
				
			}

		}
	}
}
