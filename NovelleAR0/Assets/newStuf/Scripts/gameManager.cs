using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //this is the new GameManager
    //this game managet is for object mode
    //valeus

    //unlock
    public GameObject cover0;
    public GameObject cover1;
    public GameObject cover2;
    public GameObject cover3;
    public GameObject cover4;

    public GameObject PurchasePanel;

    public void Prem()
    {
        PurchasePanel.SetActive(true);
    }
    public void BackFromPrem()
    {
        PurchasePanel.SetActive(false);
    }

    private void Start()
    {
        //if(InAppPurchasing.IsProductOwned(EM_IAPConstants.Product_Premium_Stuff))
        //{
            //cover0.SetActive(false);
            //cover1.SetActive(false);
            //cover2.SetActive(false);
            //cover3.SetActive(false);
            //cover4.SetActive(false);
        //}
    }

    //checking valeus to know what is going on
    public int ModelSelected;
    public int Mode;

    //Models
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public GameObject Model5;

    //UI Objects and UI stuf
    public GameObject ColourPanel;

    public GameObject IndicatorModlUI1;
    public GameObject IndicatorModlUI2;
    public GameObject IndicatorModlUI3;
    public GameObject IndicatorModlUI4;
    public GameObject IndicatorModlUI5;

    //end of valeus start of functions

    //General functions
    private void Awake()
    {
        ColourPanel.SetActive(false);
        ModelSelected = 0;
        SetAllUIFalse();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void StopTime()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

    //UI functions basic
    void SetAllUIFalse()
    {
        IndicatorModlUI1.SetActive(false);
        IndicatorModlUI2.SetActive(false);
        IndicatorModlUI3.SetActive(false);
        IndicatorModlUI4.SetActive(false);
        IndicatorModlUI5.SetActive(false);
    }
    void ModelUI1()
    {
        SetAllUIFalse();
        IndicatorModlUI1.SetActive(true);
    }
    void ModelUI2()
    {
        SetAllUIFalse();
        IndicatorModlUI2.SetActive(true);
    }
    void ModelUI3()
    {
        SetAllUIFalse();
        IndicatorModlUI3.SetActive(true);
    }
    void ModelUI4()
    {
        SetAllUIFalse();
        IndicatorModlUI4.SetActive(true);
    }
    void ModelUI5()
    {
        SetAllUIFalse();
        IndicatorModlUI5.SetActive(true);
    }

    //Model selection functions
    public void GenSettings()
    {
        SetAllUIFalse();
        ModelSelected = 0;
    }
    public void SelectM1()
    {
        if (ModelSelected != 1)
        {
            ModelSelected = 1;
            ModelUI1();
        }
        else if (ModelSelected == 1)
        {
            GenSettings();
        }
    }
    public void SelectM2()
    {
        if (ModelSelected != 2)
        {
            ModelSelected = 2;
            ModelUI2();
        }
        else if (ModelSelected == 2)
        {
            GenSettings();
        }
    }
    public void SelectM3()
    {
        if (ModelSelected != 3)
        {
            ModelSelected = 3;
            ModelUI3();
        }
        else if (ModelSelected == 3)
        {
            GenSettings();
        }
    }
    public void SelectM4()
    {
        if (ModelSelected != 4)
        {
            ModelSelected = 4;
            ModelUI4();
        }
        else if (ModelSelected == 4)
        {
            GenSettings();
        }
    }
    public void SelectM5()
    {
        if (ModelSelected != 5)
        {
            ModelSelected = 5;
            ModelUI5();
        }
        else if (ModelSelected == 5)
        {
            GenSettings();
        }
    }

    public void DeselectAll()
    {
        Mode = 0;
        ModelSelected = 0;
        SetAllUIFalse();
    }
}
