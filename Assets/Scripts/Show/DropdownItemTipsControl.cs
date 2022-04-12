using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownItemTipsControl : MonoBehaviour
{

    private void Start()
    {
        // dropdown.options.RemoveAt(1);
        Toggle toggle = gameObject.GetComponent<Toggle>();
        if (toggle != null && toggle.name == "Item 1: Option B")
        {
            toggle.interactable = false;
        }
    }


    public void OnDropdownItemEnter()
    {
        TMP_Text text = this.GetComponentInChildren<TMP_Text>();
        // Debug.LogWarning("OnDropdownItemEnter+   value=" + value);
        // 
        // Debug.LogWarning("OnDropdownItemEnter-   value=" + value);

        Debug.LogWarning("OnDropdownItemEnter   this="+ this);
        Debug.LogWarning("OnDropdownItemEnter   text=" + text.text);
    }

    public void OnDropdownItemExit()
    {
        TMP_Text text = this.GetComponentInChildren<TMP_Text>();
        // int value = dropdown.value;
        // Debug.LogWarning("OnDropdownItemExit+   value=" + value);
        // 
        // Debug.LogWarning("OnDropdownItemExit-   value=" + value);

        Debug.LogWarning("OnDropdownItemExit   this=" + this);
        Debug.LogWarning("OnDropdownItemExit   text." + text.text);
    }
}
