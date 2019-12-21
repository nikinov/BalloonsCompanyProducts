using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    Transform T;
    public Material mat;
    public float scaleX;
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
    private void Start()
    {
        T = gameObject.GetComponent<Transform>();
    }
    private void Update()
    {
        if (gameObject == true)
        {
            scaleX = T.localScale.x;
            //Shader.SetGlobalFloat("_Scalee", scaleX);
            //scaleX = mat.GetFloat("_Scalee");
            mat.SetFloat("_Scalee", scaleX * 0.4f);
        }
    }
}
