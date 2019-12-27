using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    public Selector selector;

    public void Scale(float A)
    {
        selector.selectedObject.transform.localScale = new Vector3(1 + 24 * A, 1 + 24 * A, 1 + 24 * A);
    }
    public void Hight(float A)
    {
        Vector3 vector = selector.selectedObject.transform.position;
        float X = vector.x;
        float Z = vector.z;
        selector.selectedObject.transform.position = new Vector3(X, (3 * A) - 0.5f, Z);
    }
}
