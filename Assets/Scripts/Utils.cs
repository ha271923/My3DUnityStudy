using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Utils
{
	static public string getGameObjectName(GameObject currentGO) {
		string currentGOname = currentGO.transform.name;
		Debug.Log("current GO Name=" + currentGOname);
		return currentGOname;
	}

	static public Type getScriptName(GameObject currentGO)
	{

		// Debug.Log("this.GetType().Name=" + this.GetType().Name); // script name
		var currentScriptname = currentGO.GetType();
		Debug.Log("current script Name=" + currentScriptname); // script name
		return currentScriptname;
	}

	static public bool findChildGO(GameObject currentGO, string childGO) {
		getGameObjectName(currentGO);
		var childCount = currentGO.transform.childCount;
		if (childCount != 0)
			for (int i = 0; i < childCount; i++)
				if (currentGO.transform.GetChild(i).gameObject.transform.name == childGO)
				{
					Debug.Log("found child GO=" + childGO);
					return true;
				}

		return false;
	}


	static public bool findParentGO(GameObject currentGO, string parentGO)
	{
		getGameObjectName(currentGO);
		if (currentGO.gameObject.transform.parent != null)
		{
			var parentGameObject = currentGO.gameObject.transform.parent.gameObject;
			if (parentGameObject != null)
			{
				Debug.Log("found parent GO=" + parentGameObject.transform.name);
				return true;
			}
		}
		return true;
	}

	static public void printChildGOs(GameObject currentGO)
	{
		var childCount = currentGO.transform.childCount;
		if (childCount != 0)
		{
			for (int i = 0; i < childCount; i++)
			{
				Debug.Log("transform.GetChild(" + i + ").gameObject.transform.name=" +
					currentGO.transform.GetChild(i).gameObject.transform.name);
			}

		}
	}

	static public string getSceneName()
	{
		string sceneName = SceneManager.GetActiveScene().name;
		Debug.Log("sceneNameO=" + sceneName);
		return sceneName;
	}

}
