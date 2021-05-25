using UnityEngine;

// My Asset STEP1. Define Asset
[CreateAssetMenu(fileName = "AssetTest", menuName = "__Asset/AssetTest")]
public sealed class AssetTest : ScriptableObject
{

    public int age;
    public float height;
    public GameObject obj;
    public Sprite sprite;
    public AudioClip audioClip;

}