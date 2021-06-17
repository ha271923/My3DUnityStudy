using TMPro;
using HTC.UnityPlugin.CommonEventVariable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIoutInputFieldHandler : MonoBehaviour
{
    [SerializeField] 
    private CommonVariableAssetString inStringVariable;
    public TMP_InputField outInputField;

    private void Awake()
    {
        if (outInputField == null)
            Debug.LogError("outInputField is null");
    }

    private void OnEnable()
    {
        outInputField.text = inStringVariable.Handler.CurrentValue;
        outInputField.onValueChanged.AddListener(OnTextStringChanged);
    }

    private void OnDisable()
    {
        outInputField.onValueChanged.RemoveListener(OnTextStringChanged);
    }

    void OnTextStringChanged(string value)
    {
        Debug.Log("OnTextStringChanged  value=" + value);
    }
}
