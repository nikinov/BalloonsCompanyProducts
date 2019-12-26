using System;
using System.Collections;
using System.Collections.Generic;
using newStuf.Scripts;
using UnityEngine;
[RequireComponent(typeof(Selector),typeof(MovingModule)),
 RequireComponent(typeof(RotationModule)),
 RequireComponent(typeof(ColorChenger)),
 RequireComponent(typeof(DuplicateModule))]
public class EditorModule : MonoBehaviour,ISelectionState
{
    public GameObject RightPanel;
    public GameObject LeftPanel;
    public GameObject Back;
    public GameObject BackD;

    private Selector selector;
    private MovingModule movingModule;
    private RotationModule rotationModule;
    private ColorChenger colorChenger;
    private DuplicateModule duplicateModule;
    
    private enum EditorState
    {
        Default,
        Moving,
        Rotating,
        Duplicating,
        ColorChanging
    }

    private EditorState lastState = EditorState.Default;
    
    private void Awake()
    {
        selector = GetComponent<Selector>();
        movingModule = GetComponent<MovingModule>();
        rotationModule = GetComponent<RotationModule>();
        colorChenger = GetComponent<ColorChenger>();
        duplicateModule = GetComponent<DuplicateModule>();

        Back.SetActive(false);
        BackD.SetActive(false);
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
                lastState = EditorState.Moving;
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
            lastState = EditorState.Moving;
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
            lastState = EditorState.Rotating;
        }
        else
        {
            if (selector.IsSelected) rotationModule.StatrtRotation(selector.selectedObject);
        }
    }
    
    public void Duplicate()
    {
        RightPanel.SetActive(false);
        LeftPanel.SetActive(false);
        BackD.SetActive(true);
        if (duplicateModule.IsDuplicating)
        {
            duplicateModule.EndDuplicating();
            lastState = EditorState.Duplicating;
        }
        else
        {
            duplicateModule.StartDuplicating(selector.selectedObject);
        }
    }

    public void Revert()
    {
        switch (lastState)
        {
            case EditorState.Moving:
                movingModule.RevertMoving();
                break;
            case EditorState.Rotating:
                rotationModule.RevertRotation();
                break;
            case  EditorState.Duplicating:
                duplicateModule.RevertDuplication();
                break;
            case EditorState.ColorChanging:
                colorChenger.RevertColors();
                break; 
        }
        
        lastState = EditorState.Default;
    }

    public void ChangeColors()
    {
        if (colorChenger.IsChengingColor)
        {
            lastState = EditorState.ColorChanging;
        }
        
        colorChenger.IsChengingColor = !colorChenger.IsChengingColor;
    }

    public void GoFromRotationBack()
    {
        Rotate();
        RightPanel.SetActive(true);
        LeftPanel.SetActive(true);
        Back.SetActive(false);
    }
    public void GoFromDuplicationBack()
    {
        Duplicate();
        RightPanel.SetActive(true);
        LeftPanel.SetActive(true);
        BackD.SetActive(false);
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

            if (duplicateModule.IsDuplicating)
            {
                duplicateModule.EndDuplicating();
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
            rotationModule.RevertRotation();
        
        if(duplicateModule.IsDuplicating)
            duplicateModule.RevertDuplication();
        
        if(colorChenger.IsChengingColor)
            colorChenger.RevertColors();
    }
}
