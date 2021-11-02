using HTC.UnityPlugin.CommonEventVariable;
using UnityEngine;
using UnityEngine.UI;

public class UIBoolHandler : MonoBehaviour
{
    [SerializeField] protected CommonEventAssetBool eventHandler;
    [SerializeField] protected CommonVariableAssetBool currentVariableHandler;
    [SerializeField] protected CommonVariableAssetBool variableReceiver;
    
    protected Toggle toggleSwitch;

    protected virtual void Awake()
    {
        toggleSwitch = GetComponent<Toggle>();
    }

    protected virtual void OnEnable()
    {    
        UpdateState();
        variableReceiver.Handler.OnChange += OnValueChanged;

        toggleSwitch.onValueChanged.AddListener(OnUIToggleValueChanged);
    }

    protected virtual void OnDisable()
    {
        variableReceiver.Handler.OnChange -= OnValueChanged;
        toggleSwitch.onValueChanged.RemoveListener(OnUIToggleValueChanged);
    }

    protected virtual void OnValueChanged()
    {

    }

    protected virtual void UpdateState()
    {
        if (currentVariableHandler.Handler.CurrentValue == variableReceiver.Handler.CurrentValue)
        {
            return;
        }

        currentVariableHandler.Handler.SetValue(variableReceiver.Handler.CurrentValue);
    }

    public virtual void OnUIToggleValueChanged(bool value)
    {
        currentVariableHandler.Handler.SetValue(value);
        eventHandler.Trigger1(currentVariableHandler.Handler.CurrentValue);
    }
}
