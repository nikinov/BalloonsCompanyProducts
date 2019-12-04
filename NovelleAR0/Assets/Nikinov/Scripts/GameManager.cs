using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obj0;
    public GameObject obj1;

    public GameObject colourUI1;

    public GameObject obj0UI;
    public GameObject obj1UI;

    private void Awake()
    {
        obj0.SetActive(false);
        obj1.SetActive(false);

        obj0UI.SetActive(false);
        obj1UI.SetActive(false);
    }

    public void SetA ()
    {
        obj0.SetActive(true);
        obj1.SetActive(false);

        obj0UI.SetActive(true);
        obj1UI.SetActive(false);
    }
    public void SetB()
    {
        obj0.SetActive(false);
        obj1.SetActive(true);

        obj0UI.SetActive(false);
        obj1UI.SetActive(true);
    }
}
