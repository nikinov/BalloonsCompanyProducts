using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    public GameObject EditorPanel;
    [SerializeField] private Transform cameraPos;

    public ISelectionState SelectionState;
    
    private RaycastHit lastRaycastHit;

    
    public GameObject selectedObject { private set; get; }
    private bool _isSelected;

    public bool IsSelected => _isSelected;

    private GameObject tempSelectedObject;

    private void Awake()
    {

        EditorPanel.SetActive(false);
    }
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
                tempSelectedObject = lastRaycastHit.collider.gameObject;
            }
        }
    }

    public void TryToSelect()
    {
        if(tempSelectedObject == null) return;
        
        selectedObject = tempSelectedObject.transform.root.gameObject;
        if (selectedObject != null)
        {
            Selectable selectable = selectedObject.GetComponent<Selectable>();
            if (selectable == null) selectable = selectedObject.GetComponentInChildren<Selectable>();

            if (selectable != null)
            {
                EditorPanel.SetActive(true);
                selectable.Selected();
                SelectionState.OnSelected();
                _isSelected = true;
            }
        }
    }

    public void Deselect()
    {
        EditorPanel.SetActive(false);
    
        Selectable selectable = selectedObject.GetComponent<Selectable>();
        if (selectable == null) selectable = selectedObject.GetComponentInChildren<Selectable>();
        
        selectable.Deselected();
        SelectionState.OnDeselected();
        selectedObject = null;
        _isSelected = false;
    }
}
