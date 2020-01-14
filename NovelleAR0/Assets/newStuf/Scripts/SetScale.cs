using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    public Selector selector;

    private Transform initalObjTr;
    private Vector3 intialPos;

    [SerializeField] private float heightSensitivity;
    public void Scale(float A)
    {
        selector.selectedObject.transform.localScale = new Vector3(1 + 24 * A, 1 + 24 * A, 1 + 24 * A);
    }
    public void Hight(float A)
    {
        GameObject selected = selector.selectedObject;

        if(selected.transform != initalObjTr){
            initalObjTr = selected.transform;
            intialPos = initalObjTr.position;
        }
            
        Vector3 vector = selector.selectedObject.transform.position;
        float X = vector.x;
        float Z = vector.z;
        

        Collider collider = selected.GetComponent<Collider>();
        if (collider == null)
            collider = selected.GetComponentInChildren<Collider>();
        //Debug.Log(A + "," + "  " + collider.bounds.size.y);
        selector.selectedObject.transform.position = new Vector3(X, intialPos.y + heightSensitivity * collider.bounds.size.y * A , Z);
    }
}
