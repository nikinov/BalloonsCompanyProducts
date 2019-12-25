using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    GameObject cam;
    Camera camer;
    public GameObject obj;
    public GameObject objCh;

    private void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        camer = cam.GetComponent<Camera>();
        objCh.SetActive(false);
    }
    private void Update()
    {
        Ray ray = camer.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == obj)
            {
                objCh.SetActive(true);
            }
            //else if (hit.transform != gameObject)
            //{
                //editor.SetF();
                //ThisIsSelected = false;
            //}
        }
    }
}
