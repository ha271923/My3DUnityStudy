using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIIntSliderHandler : UIIntHandler, IPointerUpHandler, IPointerDownHandler//, IEndDragHandler
{
    [SerializeField] private Slider slider;
    //[SerializeField] private TextMeshProUGUI SliderText;

    public bool disableRecieverWhenDragging = true;
    public float disableRecieverFinishDelay = 0.0f;
    public bool updateValueOnEndDrag = false;

    private bool disableReciever = false;

    protected override void OnEnable()
    {
        base.OnEnable();

        //Debug.Log(gameObject.name + " Current UI value: " + currentVariableHandler.Handler.CurrentValue);
        //Debug.Log(gameObject.name + " Receive value: " + variableReceiver.Handler.CurrentValue);
        //int clamp_value = Mathf.RoundToInt(Mathf.Clamp(currentVariableHandler.Handler.CurrentValue, slider.minValue, slider.maxValue));
        //slider.value = clamp_value;
        //slider.onValueChanged.Invoke(clamp_value);
        slider.onValueChanged.AddListener(OnSliderbarValueChanged);
        //SliderText.text = clamp_value.ToString() + "%";
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        slider.onValueChanged.RemoveListener(OnSliderbarValueChanged);
    }

    private void OnSliderbarValueChanged(float value)
    {
        int ivalue = Mathf.RoundToInt(value);
        if (ivalue != currentVariableHandler.Handler.CurrentValue)
        {
            if (IsInvoking(nameof(EnableReciever))) CancelInvoke(nameof(EnableReciever));
            if (disableRecieverWhenDragging) disableReciever = true;
            Debug.Log("[Settings][UIIntSliderHandler][" + gameObject.name + "] send value: " + ivalue + " (" + eventHandler + ")");
            currentVariableHandler.Handler.SetValue(ivalue);
            eventHandler.Trigger1(currentVariableHandler.Handler.CurrentValue);
        }
    }

    protected override void OnReceiverValueChanged()
    {
        if (disableReciever)
        {
            Debug.Log("[Settings][UIIntSliderHandler][" + gameObject.name + "] Slider is now dragging, ingore receive value: " + variableReceiver.Handler.CurrentValue);
            return;
        }

        Debug.Log("[Settings][UIIntSliderHandler][" + gameObject.name + "] Receive value: " + variableReceiver.Handler.CurrentValue);

        if (variableReceiver.Handler.CurrentValue != currentVariableHandler.Handler.CurrentValue)
        {
            int clamp_value = Mathf.RoundToInt(Mathf.Clamp(variableReceiver.Handler.CurrentValue, slider.minValue, slider.maxValue));
            currentVariableHandler.SetValue(clamp_value);
            slider.value = clamp_value;
            slider.onValueChanged.Invoke(currentVariableHandler.Handler.CurrentValue);
            Debug.Log("[Settings][UIIntSliderHandler][" + gameObject.name + "] update slider value: " + clamp_value);
        }
    }

    public override void UpdateValue()
    {
        base.UpdateValue();

        int clamp_value = Mathf.RoundToInt(Mathf.Clamp(currentVariableHandler.Handler.CurrentValue, slider.minValue, slider.maxValue));
        slider.value = clamp_value;
        slider.onValueChanged.Invoke(clamp_value);
        //SliderText.text = clamp_value.ToString() + "%";
    }

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    if (updateValueOnEndDrag)
    //    {
    //        Debug.Log("[Settings][Slider][" + gameObject.name + "] update value on end drag");
    //        UpdateValue();
    //    }
    //}

    public void OnPointerUp(PointerEventData eventData)
    {
        if (disableRecieverWhenDragging)
        {
            if (IsInvoking(nameof(EnableReciever))) CancelInvoke(nameof(EnableReciever));
            Invoke(nameof(EnableReciever), disableRecieverFinishDelay);
        }

        if (updateValueOnEndDrag)
        {
            Debug.Log("[Settings][Slider][" + gameObject.name + "] update value on end drag");
            UpdateValue();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (IsInvoking(nameof(EnableReciever))) CancelInvoke(nameof(EnableReciever));
        if (disableRecieverWhenDragging) disableReciever = true;
    }

    private void EnableReciever()
    {
        disableReciever = false;
    }
}