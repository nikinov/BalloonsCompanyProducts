using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnInventory : MonoBehaviour
{
    /*public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public GameObject Model5;
    public GameObject Model6;
    public GameObject Model7;
    public GameObject Model8;
    public GameObject Model9;
    public GameObject Model10;
    public GameObject Model11;
    public GameObject Model12;
    public GameObject Model13;
    public GameObject Model14;
    public GameObject Model15;
    public GameObject Model16;
    public GameObject Model17;
    public GameObject Model18;
    public GameObject Model19;
    public GameObject Model20;
    public GameObject Model21;
    public GameObject Model22;
    public GameObject Model23;
    public GameObject Model24;
    public GameObject Model25;
    public GameObject Model26;
    public GameObject Model27;
    public GameObject Model28;
    public GameObject Model29;
    public GameObject Model30;
    public GameObject Model31;
    public GameObject Model32;
    public GameObject Model33;
    public GameObject Model34;
    public GameObject Model35;*/

    public GameObject InventoryPanel;

    private void Awake()
    {
        InventoryPanel.SetActive(false);
    }
    public void OpenInventory()
    {
        InventoryPanel.SetActive(true);
    }
    public void CloseInventory()
    {
        InventoryPanel.SetActive(false);
    }
}
