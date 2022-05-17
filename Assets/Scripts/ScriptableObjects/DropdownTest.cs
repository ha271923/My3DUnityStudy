using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static TMPro.TMP_Dropdown;

public class DropdownTest : MonoBehaviour
{
    static public List<OptionData> sInteractionMethodOptions = new List<OptionData>();
    /*
    TMPro.TMP_Dropdown interactionMethodDropdown;

    private void OnEnable()
    {

        initInteractionMethodOptions2();
    }

    private void initInteractionMethodOptions()
    {
        LocalizedString ls;
        interactionMethodDropdown = GetComponent<TMPro.TMP_Dropdown>();
        interactionMethodDropdown.ClearOptions();
        ls = new LocalizedString(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_FINCH);
        OptionData optionData_FINCH = new OptionData(ls);
        sInteractionMethodOptions.Add(optionData_FINCH);
        ls = new LocalizedString(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_PAC);
        OptionData optionData_PAC = new OptionData(ls);
        sInteractionMethodOptions.Add(optionData_PAC);
        ls = new LocalizedString(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_GAZE);
        OptionData optionData_GAZE = new OptionData(ls);
        sInteractionMethodOptions.Add(optionData_GAZE);
        // interactionMethodDropdown.AddOptions(interactionMethodDropdown);
    }

    private void initInteractionMethodOptions2()
    {
        LocalizedString ls;
        interactionMethodDropdown = GetComponent<TMPro.TMP_Dropdown>();
        interactionMethodDropdown.ClearOptions();
        sInteractionMethodOptions.Add(new TMP_Dropdown.OptionData(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_FINCH));
        sInteractionMethodOptions.Add(new TMP_Dropdown.OptionData(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_PAC));
        sInteractionMethodOptions.Add(new TMP_Dropdown.OptionData(ScriptLocalization.Settings.KIOSK_INTERACTION_MODE_GAZE));
        interactionMethodDropdown.AddOptions(sInteractionMethodOptions);
    }*/
}
