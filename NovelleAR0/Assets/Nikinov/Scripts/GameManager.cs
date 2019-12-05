using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Model0;
    public GameObject Model1;
    public GameObject Model0Panel;
    public GameObject Model1Panel;
    public GameObject Model0Selected;
    public GameObject Model1Selected;


    private void Awake()
    {
        Model0.SetActive(true);
        Model1.SetActive(true);
        Model0Selected.SetActive(false);
        Model1Selected.SetActive(false);
    }
    public void Modl0()
    {
        Model0Selected.SetActive(true);
        Model1Selected.SetActive(false);
        Model0Panel.SetActive(true);
        Model1Panel.SetActive(false);
    }
    public void Modl1()
    {
        Model1Selected.SetActive(true);
        Model0Selected.SetActive(false);
        Model0Panel.SetActive(false);
        Model1Panel.SetActive(true);
    }
}
