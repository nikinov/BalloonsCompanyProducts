using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Selectable = newStuf.Scripts.Selectable;

public class Selector : MonoBehaviour
{
    public GameObject EditorPanel;
    public GameObject GenSettings;
    [SerializeField] private Transform cameraPos;

    public ISelectionState SelectionState;
    
    private RaycastHit lastRaycastHit;

    
    public GameObject selectedObject {set; get; }
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
                GenSettings.SetActive(false);
                selectable.Selected();
                SelectionState.OnSelected();
                _isSelected = true;
            }
        }
    }

    public void Deselect()
    {
        EditorPanel.SetActive(false);
        GenSettings.SetActive(true);

        Selectable selectable = selectedObject.GetComponent<Selectable>();
        if (selectable == null) selectable = selectedObject.GetComponentInChildren<Selectable>();
        
        selectable.Deselected();
        SelectionState.OnDeselected();
        selectedObject = null;
        _isSelected = false;
    }
}
