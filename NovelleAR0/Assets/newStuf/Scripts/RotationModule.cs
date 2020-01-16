﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationModule : MonoBehaviour
{

    private Transform objToRotate;
    private bool _isRotating;

    public bool IsRotating => _isRotating;


    [SerializeField] private float sensitivity = 0.1f;
    private Vector2 touchStart;
    private Vector3 initalRotation;

    private void Update()
    {
        if (_isRotating)
        {
            DetectTouches();
        }
    }

    private void DetectTouches()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    touchStart = touch.position;
                    initalRotation = objToRotate.localRotation.eulerAngles;
                    
                    break;
                case TouchPhase.Moved:

                    Rotate(touch.position,Input.touchCount == 2 );
                    
                    break;
                case TouchPhase.Ended:
                    

                    break;
            }
        }
    }

    private void Rotate(Vector2 touchPos,bool modifyZ)
    {
        Vector3 roatation = initalRotation;

        Vector2 lenghtVector = touchPos - touchStart;
        Vector2 diraction = lenghtVector.normalized;
        if (modifyZ)
        {
            roatation.z = initalRotation.z + sensitivity * (int) lenghtVector.x;
            
        }else if (Mathf.Abs(diraction.x) > Mathf.Abs(diraction.y))
        {
            roatation.y = initalRotation.y + sensitivity * (int) lenghtVector.y;
        }
        else
        {
            roatation.x = initalRotation.x + sensitivity * (int) lenghtVector.x;
        }
            
        objToRotate.localRotation = Quaternion.Euler(roatation);
    }

    public void StatrtRotation(GameObject selectedObj)
    {
        objToRotate = selectedObj.transform;
        _isRotating = true;
    }

    public void EndRotation()
    {
        objToRotate = null;
        _isRotating = false;
    }

    public void RevertRotation()
    {
        objToRotate.localRotation = Quaternion.Euler(initalRotation);
        EndRotation();
    }
    
}
