using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //this is the new GameManager
    //this game managet is for object mode
    //valeus

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
    public GameObject ModlUI1;
    public GameObject ModlUI2;
    public GameObject ModlUI3;
    public GameObject ModlUI4;
    public GameObject ModlUI5;

    public GameObject IndicatorModlUI1;
    public GameObject IndicatorModlUI2;
    public GameObject IndicatorModlUI3;
    public GameObject IndicatorModlUI4;
    public GameObject IndicatorModlUI5;

    //end of valeus start of functions

    //General functions
    private void Awake()
    {
        ModelSelected = 0;
        SetAllUIFalse();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    //UI functions basic
    void SetAllUIFalse()
    {
        ModlUI1.SetActive(false);
        ModlUI2.SetActive(false);
        ModlUI3.SetActive(false);
        ModlUI4.SetActive(false);
        ModlUI5.SetActive(false);

        IndicatorModlUI1.SetActive(false);
        IndicatorModlUI2.SetActive(false);
        IndicatorModlUI3.SetActive(false);
        IndicatorModlUI4.SetActive(false);
        IndicatorModlUI5.SetActive(false);
    }
    void ModelUI1()
    {
        SetAllUIFalse();
        ModlUI1.SetActive(true);
        IndicatorModlUI1.SetActive(true);
    }
    void ModelUI2()
    {
        SetAllUIFalse();
        ModlUI2.SetActive(true);
        IndicatorModlUI2.SetActive(true);
    }
    void ModelUI3()
    {
        SetAllUIFalse();
        ModlUI3.SetActive(true);
        IndicatorModlUI3.SetActive(true);
    }
    void ModelUI4()
    {
        SetAllUIFalse();
        ModlUI4.SetActive(true);
        IndicatorModlUI4.SetActive(true);
    }
    void ModelUI5()
    {
        SetAllUIFalse();
        ModlUI5.SetActive(true);
        IndicatorModlUI5.SetActive(true);
    }

    //Model selection functions
    public void SelectM1()
    {
        ModelSelected = 1;
        ModelUI1();
    }
    public void SelectM2()
    {
        ModelSelected = 2;
        ModelUI2();
    }
    public void SelectM3()
    {
        ModelSelected = 3;
        ModelUI3();
    }
    public void SelectM4()
    {
        ModelSelected = 4;
        ModelUI4();
    }
    public void SelectM5()
    {
        ModelSelected = 5;
        ModelUI5();
    }

    public void DeselectAll()
    {
        Mode = 0;
        ModelSelected = 0;
        SetAllUIFalse();
    }
}
