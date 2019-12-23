using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField] private SelectorUILogic selectorUI;
    [SerializeField] private Transform cameraPos;
    
    private RaycastHit lastRaycastHit;
    
    public GameObject selectedObject { private set; get; }
    private bool isSelected;
    
    void Update()
    {
        RayCastForSelectableObjects();
    }

    private void RayCastForSelectableObjects()
    {
        if (Physics.Raycast(cameraPos.position, cameraPos.forward, out lastRaycastHit))
        {
            selectorUI.PointedOnSelectableObject();
        }
    }

    public void TryToSelect()
    {
        if(lastRaycastHit.collider.gameObject == null) return;
        
        selectedObject = lastRaycastHit.collider.gameObject;
        if (selectedObject != null)
        {
            isSelected = true;
            selectorUI.OnSelected();
        }
    }

    public void Deselect()
    {
        selectedObject = null;
        isSelected = false;
        selectorUI.OnDeselected();
    }
}
