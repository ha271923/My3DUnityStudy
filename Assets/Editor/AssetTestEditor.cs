using UnityEditor;
using UnityEngine;

// My Asset STEP2. Create Asset by Editor
public class AssetTestEditor : Editor
{
    // D:\GitHub\My3DUnityStudy\Assets\Editor\Resources\Config\AssetTest.asset
    private const string ConfigDir = "Assets/Editor/Resources/Config";
    private const string AssetTest = "AssetTest";
    private const string FileNameFull = AssetTest + ".asset";

    [MenuItem("Test/Create test .asset")]
    public static void Create()
    {
        AssetDatabase.StartAssetEditing();
        AssetTest assetTest;
        assetTest = ScriptableObject.CreateInstance<AssetTest>();
        AssetDatabase.CreateAsset(assetTest, ConfigDir + "/" + FileNameFull);
        assetTest.age = 10;
        assetTest.height = 5.0f;

        EditorUtility.SetDirty(assetTest);

        //更新本地版本
        AssetDatabase.StopAssetEditing();
        AssetDatabase.SaveAssets();
    }


}