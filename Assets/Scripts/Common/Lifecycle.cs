using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
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
		Debug.Log("this=" + this);
		var objectName = this.name;
		Debug.Log("this.name=" + objectName);
		objectName = transform.name;
		Debug.Log("transform.name=" + objectName);
		objectName = this.transform.name;
		Debug.Log("this.transform.name=" + objectName);
		objectName = this.gameObject.transform.name;
		Debug.Log("this.gameObject.transform.name=" + objectName);
		objectName = gameObject.transform.name;
		Debug.Log("gameObject.transform.name=" + objectName);
		Debug.LogError("this.gameObject.GetComponent<MonoBehaviour>()=" + this.gameObject.GetComponent<MonoBehaviour>());

		Console.WriteLine("Console.WriteLine  gameObject.transform.name=" + objectName);

	}

	private void FixedUpdate()
	{
		Debug.Log("FixedUpdate()");
	}


	// Update() is called once per frame
	void Update()
	{
		Debug.Log("Update()");
	}
	private void LateUpdate()
	{
		Debug.Log("LateUpdate()");
	}

	private void OnGUI()
	{
		Debug.Log("OnGUI()");
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
