using HTC.UnityPlugin.CommonEventVariable;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIIntHandler : MonoBehaviour
{
    [SerializeField] 
    private CommonVariableAssetInt inputIntVariable;
    private Text outputTextUI;

    private void Awake()
    {
        outputTextUI = GetComponent<Text>();
        if(outputTextUI == null)
            Debug.LogError("outputTextUI is null");
    }

    private void OnEnable()
    {
        int val = Int32.Parse(outputTextUI.text);
        val = inputIntVariable.Handler.CurrentValue;
        Action callback = new Action(OnUIIntValueChanged);
        inputIntVariable.Handler.OnChange += callback;
    }

    private void OnDisable()
    {
        Action callback = new Action(OnUIIntValueChanged);
        inputIntVariable.Handler.OnChange -= callback;
    }

    public void OnUIIntValueChanged()
    {
        Debug.Log("OnTextStringChanged  value=" + inputIntVariable.Handler.CurrentValue);
        outputTextUI.text = inputIntVariable.Handler.CurrentValue.ToString();
    }
}
