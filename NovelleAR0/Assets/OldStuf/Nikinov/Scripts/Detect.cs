using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Detect : MonoBehaviour
{
    public bool isSelected;
    public EditMode edit;

    void Update()
    {
        if (gameObject)
        {
            isSelected = true;
        }
    }
    public void kill ()
    {
        edit.Desstroy();
    }
}
