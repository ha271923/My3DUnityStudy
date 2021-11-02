using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
	static bool bShowUpdateMsg = false;
	private void Reset()
	{
		Debug.Log("Reset()");
	}

	private void Awake()
	{
		Debug.Log("Awake()");
	}

	private void OnEnable()
	{
		Debug.Log("OnEnable()");
	}

	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("Start()");
		// none == this == Monobehaviour >= gameObject
		Debug.Log("this=" + this);  // L2.1 (Lifecycle)
		var objectName = this.name;
		Debug.Log("this.name=" + objectName);  // L2.1
		objectName = transform.name;
		Debug.Log("transform.name=" + objectName);  // L2.1
		objectName = this.transform.name;
		Debug.Log("this.transform.name=" + objectName);  // L2.1
		objectName = this.gameObject.transform.name;
		Debug.Log("this.gameObject.transform.name=" + objectName);  // L2.1
		objectName = gameObject.transform.name;
		Debug.Log("gameObject.transform.name=" + objectName);  // L2.1
		Debug.LogError("this.gameObject.GetComponent<MonoBehaviour>()=" + this.gameObject.GetComponent<MonoBehaviour>());  // L2.1 (Lifecycle)

		Console.WriteLine("Console.WriteLine  gameObject.transform.name=" + objectName);  // no show

	}

	private void FixedUpdate()
	{
		if (bShowUpdateMsg) Debug.Log("FixedUpdate()");
	}


	// Update() is called once per frame
	void Update()
	{
		if(bShowUpdateMsg) Debug.Log("Update()");
	}
	private void LateUpdate()
	{
		if (bShowUpdateMsg) Debug.Log("LateUpdate()");
	}

	private void OnGUI()
	{
		if (bShowUpdateMsg) Debug.Log("OnGUI()");
	}

	private void OnApplicationPause(bool pause)
	{
		Debug.Log("OnApplicationPause()");
	}

	private void OnDisable()
	{
		Debug.Log("OnDisable()");
	}

	private void OnDestroy()
	{
		Debug.Log("OnDestroy()");
	}

}
