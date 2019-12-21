using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDetection : MonoBehaviour
{
    bool Clicked;

    public Camera cam;
    public GameObject ARS;

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == ("containerB"))
            {
                StartCoroutine(wait());
            }
        }
    }
    IEnumerator wait ()
    {
        ARS.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        ARS.SetActive(true);
    }
}
