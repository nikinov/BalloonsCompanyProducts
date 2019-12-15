using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDetection : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == (""))
            {

            }
        }
    }
}
