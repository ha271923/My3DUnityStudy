using TMPro;
using HTC.UnityPlugin.CommonEventVariable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIInputFieldHandler : MonoBehaviour
{
    [SerializeField]
    public  TMP_InputField inInputField;
    private CommonVariableAssetString outStringVariable;

    private void Awake()
    {
        if (inInputField == null)
            Debug.LogError("inInputField is null");
    }

    private void OnEnable()
    {
        inInputField.text = outStringVariable.Handler.CurrentValue;
        inInputField.onValueChanged.AddListener(OnTextStringChanged);
    }

    private void OnDisable()
    {
        inInputField.onValueChanged.RemoveListener(OnTextStringChanged);
    }

    void OnTextStringChanged(string value)
    {
        Debug.Log("OnTextStringChanged  value=" + value);
    }
}
