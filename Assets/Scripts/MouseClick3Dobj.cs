using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick3Dobj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
                print(hit.collider.name);
        }
    }
}
