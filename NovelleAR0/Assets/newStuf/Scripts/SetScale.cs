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
        selector.selectedObject.transform.position = new Vector3(0, 3 * A, 0);
    }
}
