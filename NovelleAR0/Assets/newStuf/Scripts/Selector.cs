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

    MaterialHandler Handler;
    
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
            Handler = selectedObject.GetComponentInChildren<MaterialHandler>();
            Handler.SetT();
            EditorPanel.SetActive(true);
            selectedObject.GetComponentInChildren<Transform>().gameObject.GetComponentInChildren<Transform>().gameObject.SetActive(true);
            _isSelected = true;
            SelectionState.OnSelected();
        }
    }

    public void Deselect()
    {
        EditorPanel.SetActive(false);
        Handler.SetF();
        //selectedObject.GetComponentInChildren<Transform>().gameObject.GetComponentInChildren<Transform>().gameObject.SetActive(false);
        selectedObject = null;
        _isSelected = false;
        SelectionState.OnDeselected();
    }
}
