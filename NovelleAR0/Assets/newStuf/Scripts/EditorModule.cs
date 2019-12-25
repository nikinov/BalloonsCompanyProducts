using System;
using System.Collections;
using System.Collections.Generic;
using newStuf.Scripts;
using UnityEngine;
[RequireComponent(typeof(Selector),typeof(MovingModule)),RequireComponent(typeof(RotationModule)),RequireComponent(typeof(ColorChenger))]
public class EditorModule : MonoBehaviour,ISelectionState
{
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

        selector.SelectionState = this;
    }

    public void Move()
    {
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
            movingModule.EndMoving();
        }
    }

    public void Rotate()
    {
        if (rotationModule.IsRotating)
        {
            rotationModule.EndRotation();
        }
        else
        {
            if(selector.IsSelected) rotationModule.StatrtRotation(selector.selectedObject);
        }
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
