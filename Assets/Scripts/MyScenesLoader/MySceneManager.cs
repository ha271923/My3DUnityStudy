#region Assembly UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Unity\Unity2019.4.10f1\Editor\Data\Managed\UnityEditor.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEditor;

#if UNITY_EDITOR

#endif


public class MySceneManager : MonoBehaviour
{

    List<string> SceneListStrings = new List<string>();


    public string[] showTexts;//每个Item下的Text，用来显示和修改
    public Sprite[] sprites;//自己用来换每个Item的背景显示



    Dropdown dropDownItem;
    List<string> temoNames;
    List<Sprite> sprite_list;


    void Awake()
    {
        initScenes();
    }

    void initScenes()
    {

    }

    void Start()
    {
        dropDownItem = this.GetComponent<Dropdown>();
        temoNames = new List<string>();
        sprite_list = new List<Sprite>();
        dropDownItem.onValueChanged.AddListener(OnValueChange);

        AddNames();
        UpdateDropDownItem(temoNames);

    }


    void UpdateDropDownItem(List<string> showNames)
    {
        dropDownItem.options.Clear();
        Dropdown.OptionData temoData;
        for (int i = 0; i < showNames.Count; i++)
        {
            //给每一个option选项赋值
            temoData = new Dropdown.OptionData();
            temoData.text = showNames[i];
            temoData.image = sprite_list[i];
            dropDownItem.options.Add(temoData);
        }
        //初始选项的显示
        dropDownItem.captionText.text = showNames[0];

    }

    void AddNames()
    {
        for (int i = 0; i < showTexts.Length; i++)
        {
            temoNames.Add(showTexts[i]);
        }
        for (int i = 0; i < sprites.Length; i++)
        {
            sprite_list.Add(sprites[i]);
        }
    }

    void OnValueChange(int index)
    {
        //切換選項 時處理其他的邏輯...
        Debug.Log("showTexts[" + index+"]="+ showTexts[index]);
    }
}
