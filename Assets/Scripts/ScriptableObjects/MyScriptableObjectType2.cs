﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=0nW5PhQTWbQ&list=PLfvYL9lU6oPjNwzA1sNLnRYfm3b7ZYjuk&index=58
[CreateAssetMenu(fileName ="myScriptableObjectType2", menuName = "Create My ScritableObject/MyScriptableObjectType2")]
public class MyScriptableObjectType2 : ScriptableObject
{
    public string name;
    public float defense;
    public float price;
    public Sprite sp;

    private void OnValidate()
    {
        Debug.Log("OnValidate");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}