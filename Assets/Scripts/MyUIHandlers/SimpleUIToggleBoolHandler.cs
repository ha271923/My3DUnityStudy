using HTC.UnityPlugin.CommonEventVariable;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIToggleBoolHandler : MonoBehaviour
{
    [SerializeField] private CommonVariableAssetBool inBoolVariable;
    private Toggle outToggleSwitch;

    private void Awake()
    {
        outToggleSwitch = GetComponent<Toggle>();
        if (outToggleSwitch == null)
            Debug.LogError("outToggleSwitch is null");
    }

    private void OnEnable()
    {
        outToggleSwitch.isOn = inBoolVariable.Handler.CurrentValue;
        outToggleSwitch.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnDisable()
    {
        outToggleSwitch.onValueChanged.RemoveListener(OnToggleValueChanged);
    }

    public virtual void OnToggleValueChanged(bool value)
    {
        Debug.Log("OnTextStringChanged  value=" + value);
        inBoolVariable.Handler.SetValue(value);
    }
}
