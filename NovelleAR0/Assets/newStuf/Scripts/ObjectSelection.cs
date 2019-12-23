using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    Camera cam;
    SelectionEditor editor;
    bool ThisIsSelected;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
        editor = gameObject.GetComponentInChildren<SelectionEditor>();
        ThisIsSelected = false;
        editor.SetF();
    }
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == gameObject)
            {
                editor.SetT();
                ThisIsSelected = true;
            }
            else if (hit.transform != gameObject)
            {
                editor.SetF();
                ThisIsSelected = false;
            }
        }
    }
}
