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
    public bool EditMode;

    //Models
    public GameObject PlacePoss;
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public GameObject Model5;

    //UI Objects and UI stuf
    public GameObject GenetalSettings;
    public GameObject SpawnButton;
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

    //LeftPanle objects
    public GameObject Lpanel0;
    public GameObject Lpanel1;
    public GameObject Lpanel2;
    public GameObject Lpanel3;
    public GameObject Lpanel4;
    public GameObject Lpanel5;

    //left panels object mode

    GameObject LeftPanel
    {
        get
        {
            switch (ModelSelected)
            {
                case 1:
                    return Lpanel1;
                    break;
                case 2:
                    return Lpanel2;
                    break;
                case 3:
                    return Lpanel3;
                    break;
                case 4:
                    return Lpanel4;
                    break;
                case 5:
                    return Lpanel5;
                    break;
                default:
                    return Lpanel0;
                    break;
            }
        }
    }

    //end of valeus start of functions

    //General functions
    private void Awake()
    {
        SpawnButton.SetActive(false);
        ModelSelected = 0;
        SetAllUIFalse();
        GenetalSettings.SetActive(true);
        SetLeftPanel();
    }
    private void Update()
    {
        if (EditMode)
        {
            if (PlacePoss)
            {
                PlacePoss.SetActive(false);
            }
            if (ModelSelected > 0)
            {
                EditMode = false;
                PlacePoss.SetActive(true);
                SpawnButton.SetActive(true);
            }
        }
        else if (!EditMode)
        {
            if (ModelSelected == 0)
            {
                EditMode = true;
                SpawnButton.SetActive(false);
            }
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    //UI functions basic
    public void SetAllUIFalse()
    {
        GenetalSettings.SetActive(false);
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
    public void SetLeftPanel()
    {
        Lpanel0.SetActive(false);
        Lpanel1.SetActive(false);
        Lpanel2.SetActive(false);
        Lpanel3.SetActive(false);
        Lpanel4.SetActive(false);
        Lpanel5.SetActive(false);
        LeftPanel.SetActive(true);
    }
    void ModelUI1()
    {
        SetAllUIFalse();
        ModlUI1.SetActive(true);
        IndicatorModlUI1.SetActive(true);
        SetLeftPanel();
    }
    void ModelUI2()
    {
        SetAllUIFalse();
        ModlUI2.SetActive(true);
        IndicatorModlUI2.SetActive(true);
        SetLeftPanel();
    }
    void ModelUI3()
    {
        SetAllUIFalse();
        ModlUI3.SetActive(true);
        IndicatorModlUI3.SetActive(true);
        SetLeftPanel();
    }
    void ModelUI4()
    {
        SetAllUIFalse();
        ModlUI4.SetActive(true);
        IndicatorModlUI4.SetActive(true);
        SetLeftPanel();
    }
    void ModelUI5()
    {
        SetAllUIFalse();
        ModlUI5.SetActive(true);
        IndicatorModlUI5.SetActive(true);
        SetLeftPanel();
    }

    //Model selection functions
    public void GenSettings()
    {
        SetAllUIFalse();
        ModelSelected = 0;
        GenetalSettings.SetActive(true);
        SetLeftPanel();
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

    //Left Panel functions


}
