using HTC.UnityPlugin.CommonEventVariable;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIButtonHandler : MonoBehaviour
{
    [SerializeField]
    public Button inButtonUI;
    [SerializeField]
    public CommonEventAsset<int, CommonEventAssetInt.TriggerEvent> outCommonEvent;    // == CommonEventAssetInt
    public CommonVariableAsset<int, CommonVariableAssetInt.OnChangeEvent> outCommonVariable; // == CommonVariableAssetInt

    private static int eventParam;

    private void Awake()
    {
        inButtonUI = GetComponent<Button>();
        inButtonUI.onClick.AddListener(OnButtonClicked);

        outCommonEvent.Handler.OnTrigger += onEventTriggered;

        outCommonVariable.Handler.OnChange += onVariableChanged;
    }

    private void OnEnable()
    {
        inButtonUI.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        inButtonUI.onClick.RemoveListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
        Debug.Log("OnButtonClicked");
        outCommonEvent.Handler.Trigger(eventParam++);
        outCommonVariable.Handler.SetValue(outCommonVariable.Handler.CurrentValue+1);
    }

    public void onEventTriggered(int param) {
        Debug.Log("onEventTriggered  event Triggered!    eventParam="+ eventParam);
    }

    public void onVariableChanged() {
        Debug.Log("onVariableChanged  variable Changed!   CurrentValue="+ outCommonVariable.Handler.CurrentValue);

    }

}
