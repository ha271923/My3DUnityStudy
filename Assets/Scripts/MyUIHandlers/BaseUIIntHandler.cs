using HTC.UnityPlugin.CommonEventVariable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUIIntHandler : MonoBehaviour
{
    [SerializeField] protected CommonVariableAssetInt inVariableHandler; 
    [SerializeField] protected CommonEventAssetInt    outEventHandler;    // Drag XXXCommonEventAsset.asset to set it in Unity UI
    [SerializeField] protected CommonVariableAssetInt outVariableReceiver;

    protected virtual void OnEnable()
    {
        UpdateValue();
        if(outVariableReceiver == null ||  outVariableReceiver.Handler == null) 
            return;
        else
            outVariableReceiver.Handler.OnChange += OnReceiverValueChanged;
    }

    protected virtual void OnDisable()
    {
        if(outVariableReceiver == null || outVariableReceiver.Handler == null) 
            return;
        else
            outVariableReceiver.Handler.OnChange -= OnReceiverValueChanged;
    }

    protected virtual void OnReceiverValueChanged()
    {
        Debug.Log("OnReceiverValueChanged");
    }

    public virtual void UpdateValue()
    {
        if(inVariableHandler == null || inVariableHandler.Handler == null) 
            return;
        if(outVariableReceiver == null || outVariableReceiver.Handler == null) 
            return;
        if(inVariableHandler.Handler.CurrentValue == outVariableReceiver.Handler.CurrentValue)
            return;

        inVariableHandler.SetValue(outVariableReceiver.Handler.CurrentValue);
    }
}
