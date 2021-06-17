using HTC.UnityPlugin.CommonEventVariable;
using UnityEngine;
using UnityEngine.UI;

public class BaseUIBoolHandler : MonoBehaviour
{
    [SerializeField] protected CommonVariableAssetBool inVariableHandler;
    [SerializeField] protected CommonVariableAssetBool outVariableReceiver; // other variable can got onChangeValue notification also.
    [SerializeField] protected CommonEventAssetBool outEventHandler;

    protected Toggle toggleSwitch;

    private void Awake()
    {
        toggleSwitch = GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        UpdateState();
        if(outVariableReceiver == null | outVariableReceiver.Handler == null) 
            return;

        outVariableReceiver.Handler.OnChange += OnValueChanged;

        toggleSwitch.isOn = inVariableHandler.Handler.CurrentValue;
        toggleSwitch.onValueChanged.AddListener(OnUIToggleValueChanged);

    }

    private void OnDisable()
    {
        if(outVariableReceiver == null || outVariableReceiver.Handler == null) 
            return;
        
        outVariableReceiver.Handler.OnChange -= OnValueChanged;
        toggleSwitch.onValueChanged.RemoveListener(OnUIToggleValueChanged);
    }

    protected virtual void UpdateState()
    {
        if(inVariableHandler == null || inVariableHandler.Handler == null) 
            return;
        if(outVariableReceiver == null || outVariableReceiver.Handler == null) 
            return;
        if (inVariableHandler.Handler.CurrentValue == outVariableReceiver.Handler.CurrentValue)
            return;

        inVariableHandler.Handler.SetValue(outVariableReceiver.Handler.CurrentValue);
    }

    protected virtual void OnValueChanged()
    {
        Debug.Log("OnValueChanged");
    }

    public virtual void OnUIToggleValueChanged(bool value)
    {
        inVariableHandler.Handler.SetValue(value);
        outEventHandler.Trigger1(inVariableHandler.Handler.CurrentValue);
    }
}
