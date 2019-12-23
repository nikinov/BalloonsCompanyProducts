using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorUILogic : MonoBehaviour
{
    [SerializeField] private GameObject selectButton;
    [SerializeField] private GameObject deselectButton;

    public void OnSelected()
    {
        selectButton.SetActive(false);
        deselectButton.SetActive(true);
    }
    public void OnDeselected()
    {
        selectButton.SetActive(false);
        deselectButton.SetActive(false);
    }
    public void PointedOnSelectableObject()
    {
        selectButton.SetActive(true);
        deselectButton.SetActive(false);
    }
    
}
