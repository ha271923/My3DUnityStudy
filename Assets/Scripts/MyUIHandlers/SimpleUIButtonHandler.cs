using HTC.UnityPlugin.CommonEventVariable;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIButtonHandler : MonoBehaviour
{
    [SerializeField]
    private Button inButtonUI;
    [SerializeField]
    protected CommonEventAsset outCommonEvent; // Drag to set .asset in UnityUI

    private void Awake()
    {
        inButtonUI = GetComponent<Button>();
        outCommonEvent.Handler.OnTrigger += onEventTriggered;
        GameObject GO = GameObject.Find("MyEventController");
        outCommonEvent.Handler.OnTrigger += GO.GetComponent<MyEventHanlderCenter>().onUpdateEventResult0;
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
        Debug.Log("OnButtonClicked  event Triggering");
        outCommonEvent.Handler.Trigger();
    }

    public void onEventTriggered() {
        Debug.Log("onEventTriggered  event Triggered");

    }

}
