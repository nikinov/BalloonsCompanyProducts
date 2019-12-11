using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    public void Scale(float A)
    {
        transform.localScale = new Vector3(1 + 24 * A, 1 + 24 * A, 1 + 24 * A);
    }
    public void Rotate0(float A)
    {
        transform.rotation = Quaternion.Euler(0, 360 * A, -90);
    }
    public void Rotate1(float A)
    {
        transform.rotation = Quaternion.Euler(-90, 360 * A, -90);
    }
}
