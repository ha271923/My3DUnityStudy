using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownControl : MonoBehaviour
{
    TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        // dropdown.value = 2; // set default
        // dropdown.options.RemoveAt(1);
        dropdown.onValueChanged.AddListener(Dropdown_OnChange);
    }

    private void OnEnable()
    {
        dropdown.value = 2; // set default
    }

    private void Dropdown_OnChange(int value) {
        Debug.LogWarning("Dropdown_OnChange  value="+value);
        Debug.LogWarning("Dropdown_OnChange  text=" + dropdown.options[dropdown.value].text);


    }
}
