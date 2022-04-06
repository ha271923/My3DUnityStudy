using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownItemTipsControl : MonoBehaviour
{
    public void OnDropdownItemEnter()
    {
        Text text = this.GetComponentInChildren<Text>();
        // Debug.LogWarning("OnDropdownItemEnter+   value=" + value);
        // 
        // Debug.LogWarning("OnDropdownItemEnter-   value=" + value);

        Debug.LogWarning("OnDropdownItemEnter   text."+ text.text);
    }

    public void OnDropdownItemExit()
    {
        Text text = this.GetComponentInChildren<Text>();
        // int value = dropdown.value;
        // Debug.LogWarning("OnDropdownItemExit+   value=" + value);
        // 
        // Debug.LogWarning("OnDropdownItemExit-   value=" + value);

        Debug.LogWarning("OnDropdownItemExit   text." + text.text);
    }
}
