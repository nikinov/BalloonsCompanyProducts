using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDetection : MonoBehaviour
{
    bool Clicked;

    public Camera cam;

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == ("Canvas"))
            {

            }
        }
    }
}
