using System;
using System.Collections;
using System.Collections.Generic;
using newStuf.Scripts;
using UnityEngine;
[RequireComponent(typeof(Selector),typeof(MovingModule)),RequireComponent(typeof(RotationModule)),RequireComponent(typeof(ColorChenger))]
public class EditorModule : MonoBehaviour,ISelectionState
{
    public GameObject RightPanel;
    public GameObject LeftPanel;
    public GameObject Back;

    private Selector selector;
    private MovingModule movingModule;
    private RotationModule rotationModule;
    private ColorChenger colorChenger;
    
    private void Awake()
    {
        selector = GetComponent<Selector>();
        movingModule = GetComponent<MovingModule>();
        rotationModule = GetComponent<RotationModule>();
        colorChenger = GetComponent<ColorChenger>();

        Back.SetActive(false);
        selector.SelectionState = this;
    }

    public void Move()
    {
        RightPanel.SetActive(false);
        LeftPanel.SetActive(false);
        if (selector.IsSelected)
        {
            if (movingModule.IsMoving)
            {
                movingModule.EndMoving();
            }
            else
            {
                movingModule.StartMoving(selector.selectedObject);
            }
        }
    }

    public void StopMove()
    {
        if (movingModule.IsMoving)
        {
            RightPanel.SetActive(true);
            LeftPanel.SetActive(true);
            movingModule.EndMoving();
        }
    }

    public void Rotate()
    {
        RightPanel.SetActive(false);
        LeftPanel.SetActive(false);
        Back.SetActive(true);
        if (rotationModule.IsRotating)
        {
            rotationModule.EndRotation();
        }
        else
        {
            if (selector.IsSelected) rotationModule.StatrtRotation(selector.selectedObject);
        }
    }

    public void GoFromRotationBack()
    {
        Rotate();
        RightPanel.SetActive(true);
        LeftPanel.SetActive(true);
        Back.SetActive(false);
    }

    public void DeleteSelected()
    {
        if (selector.IsSelected)
        {
            if (movingModule.IsMoving)
            {
                movingModule.EndMoving();
            }

            if (rotationModule.IsRotating)
            {
                rotationModule.EndRotation();
            }
            
            colorChenger.IsChengingColor = false;

            Destroy(selector.selectedObject);
            selector.Deselect();
        }
    }

    public void OnSelected()
    {
        colorChenger.setUpChenger(selector.selectedObject);
    }

    public void OnDeselected()
    {
        if(movingModule.IsMoving)
            movingModule.RevertMoving();
            
        if(rotationModule.IsRotating)
            rotationModule.EndRotation();
        
        colorChenger.IsChengingColor = false;
    }
}
