using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public GameObject IsSelected;
    bool isSelected;

    private void Awake()
    {
        UISelectionF();
    }
    void UISelectionF()
    {
        isSelected = false;
        IsSelected.SetActive(false);
    }
    void UISelectionT()
    {
        isSelected = true;
        IsSelected.SetActive(true);
    }
    public void Click()
    {
        if(isSelected)
        {
            UISelectionF();
        }
        else if (!isSelected)
        {
            UISelectionT();
        }
    }

}
