using HTC.UnityPlugin.CommonEventVariable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIntHandler : MonoBehaviour
{
    [SerializeField] protected CommonEventAssetInt eventHandler;
    [SerializeField] protected CommonVariableAssetInt currentVariableHandler;
    [SerializeField] protected CommonVariableAssetInt variableReceiver;

    protected virtual void OnEnable()
    {
        UpdateValue();
        variableReceiver.Handler.OnChange += OnReceiverValueChanged;
    }

    protected virtual void OnDisable()
    {
        variableReceiver.Handler.OnChange -= OnReceiverValueChanged;
    }

    protected virtual void OnReceiverValueChanged()
    {
        
    }

    public virtual void UpdateValue()
    {
        if(currentVariableHandler.Handler.CurrentValue == variableReceiver.Handler.CurrentValue)
        {
            return;
        }

        currentVariableHandler.SetValue(variableReceiver.Handler.CurrentValue);
    }
}
