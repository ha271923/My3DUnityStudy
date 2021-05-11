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

	static public GameObject getCurrentSelectedGO() {
		// 一个场景只能含有一个EventSystem
		GameObject currentSelected = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
		return currentSelected;
	}

	static public bool checkIfPointerOnUI() { // Finger or Mouse

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) == true)
			{
				Debug.Log("Touched the UI");
				return true;
			}
		}
		return false;
	}

}
