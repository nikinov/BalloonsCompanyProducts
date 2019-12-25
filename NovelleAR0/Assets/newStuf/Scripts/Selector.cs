using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    [SerializeField] private SelectorUILogic selectorUI;
    [SerializeField] private Transform cameraPos;

    public ISelectionState SelectionState;
    
    private RaycastHit lastRaycastHit;

    
    public GameObject selectedObject { private set; get; }
    private bool _isSelected;

    public bool IsSelected => _isSelected;

    private GameObject tempSelectedObject;
    
    void Update()
    {
        RayCastForSelectableObjects();
    }

    private void RayCastForSelectableObjects()
    {
        bool isPointing = Physics.Raycast(cameraPos.position, cameraPos.forward, out lastRaycastHit);

        if (!_isSelected)
        {
            if (isPointing)
            {
                selectorUI.PointedOnSelectableObject();
                tempSelectedObject = lastRaycastHit.collider.gameObject;
            }
            else selectorUI.OnDeselected();
        }
    }

    public void TryToSelect()
    {
        if(tempSelectedObject == null) return;
        
        selectedObject = tempSelectedObject.transform.root.gameObject;
        if (selectedObject != null)
        {
            _isSelected = true;
            selectorUI.OnSelected();
            SelectionState.OnSelected();
        }
    }

    public void Deselect()
    {
        selectedObject = null;
        _isSelected = false;
        selectorUI.OnDeselected();
        SelectionState.OnDeselected();
    }
}
