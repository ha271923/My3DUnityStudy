using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TipsControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject tipsPrefab;
    private GameObject tipsGO;
    // Start is called before the first frame update
    void Start()
    {
        tipsGO = Instantiate(tipsPrefab, new Vector3(30, 30, 0), Quaternion.identity);
        tipsGO.SetActive(false);
        tipsGO.transform.SetParent(this.transform, false);
    }

    public void OnPointerEnter(PointerEventData data)
    {
        Debug.LogWarning("OnPointerEnter");

        tipsGO.SetActive(true);
    }

    public void OnPointerExit(PointerEventData data)
    {
        Debug.LogWarning("OnPointerExit");
        tipsGO.SetActive(false);
    }
}
