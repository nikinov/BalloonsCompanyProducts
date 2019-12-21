using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditMode : MonoBehaviour
{
    public Camera cam;
    public ChangeMode mode;
    GameObject childd;
    public GameObject TestCh;
    MeshRenderer renderer;

    private void Awake()
    {
        renderer = TestCh.GetComponent<MeshRenderer>();
        childd = gameObject.transform.GetChild(0).gameObject;
    }
    void Update()
    {
        renderer.enabled = false;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (mode.ARN == true)
            {
                if (hit.transform.gameObject)
                {
                    if (renderer == true)
                    {
                        renderer.enabled = false;
                    }
                    else if (renderer == false)
                    {
                        renderer.enabled = true;
                    }
                }
            }
        }
    }
    public void Desstroy()
    {
        if (gameObject.GetComponentInChildren<Detect>().isSelected)
        {
            gameObject.SetActive(false);
        }
    }
}
