using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDetection : MonoBehaviour
{
    bool Clicked;

    void Update()
    {
        Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == ("Canvas"))
            {

            }
        }
    }
    IEnumerator OnClick()
    {
        Clicked = true;
        yield return new WaitForEndOfFrame();
        Clicked = false;
    }
    public void Click(GameObject A)
    {
        Destroy(A);
    }
}
