using System.Collections;
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
}
