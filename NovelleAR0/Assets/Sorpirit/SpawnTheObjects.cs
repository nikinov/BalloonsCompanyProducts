using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTheObjects : MonoBehaviour
{

    public bool isDuplicating;

    public GameObject objectToSpawn;

    private PlaceOnPlane placeOnPlane;

    private void Awake()
    {
        placeOnPlane = GetComponent<PlaceOnPlane>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if (isDuplicating && placeOnPlane.IsPlaceAvaileble(touch.position))
            {
                placeOnPlane.content = Instantiate(objectToSpawn,Vector3.zero,Quaternion.identity).transform;
                placeOnPlane.PlaceObj(placeOnPlane.touchHitPos());
            }
            else
            {
                if (placeOnPlane.content == null && placeOnPlane.IsPlaceAvaileble(touch.position))
                {
                    placeOnPlane.content = Instantiate(objectToSpawn,Vector3.zero,Quaternion.identity).transform;
                    placeOnPlane.PlaceObj(placeOnPlane.touchHitPos());
                }
            }
        }
    }
}
