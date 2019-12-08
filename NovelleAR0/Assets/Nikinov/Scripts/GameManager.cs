using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Model0;
    public GameObject Model1;
    public GameObject Model0Selected;
    public GameObject Model1Selected;

    public GameObject Panel0;
    public GameObject Panel1;
    public GameObject Colours;

    public Material mat0;
    public Material mat1;
    public Material mat2;
    public Material mat3;

    float WeAreIn;
    int ChangeMat;

    public FlexibleColorPicker picker;

    public void test()
    {
        Debug.Log("it workes");
    }
    private void Awake()
    {
        SetModelsFalse();
    }
    void SetModelsFalse ()
    {
        Model0.SetActive(false);
        Model1.SetActive(false);

        Model0Selected.SetActive(true);
        Model1Selected.SetActive(true);
        WeAreIn = -1;
    }
    void SetPanelsFalse ()
    {
        Panel0.SetActive(false);
        Panel1.SetActive(false);

        Colours.SetActive(false);
    }
    public void CheckPanels()
    {
        switch (WeAreIn)
        {
            case 0:
                SetPanelsFalse();
                Panel0.SetActive(true);
                break;
            case 1:
                SetPanelsFalse();
                Panel1.SetActive(true);
                break;
            default:
                SetPanelsFalse();
                break;
        }
    }
    public void Modl0()
    {
        SetModelsFalse();
        Model0.SetActive(true);
        Model0Selected.SetActive(false);
        WeAreIn = 0;
        CheckPanels();
    }
    public void Modl1()
    {
        SetModelsFalse();
        Model1.SetActive(true);
        Model1Selected.SetActive(false);
        Panel1.SetActive(true);
        WeAreIn = 1;
        CheckPanels();
    }
    void OpenColourEdit ()
    {
        SetPanelsFalse();
        Colours.SetActive(true);
    }
    public void CloseColourEdit()
    {
        CheckPanels();
    }
    public void SetMat()
    {
        switch (ChangeMat)
        {
            case 0:
                mat0.color = picker.color;
                break;
            case 1:
                mat1.color = picker.color;
                break;
            case 2:
                mat2.color = picker.color;
                break;
            case 3:
                mat3.color = picker.color;
                break;
            default:
                Debug.Log("Error on SetMat()");
                break;
        }
    }
    public void ChangeMat0()
    {
        ChangeMat = 0;
        OpenColourEdit();
    }
    public void ChangeMat1()
    {
        ChangeMat = 1;
        OpenColourEdit();
    }
    public void ChangeMat2()
    {
        ChangeMat = 2;
        OpenColourEdit();
    }
    public void ChangeMat3()
    {
        ChangeMat = 3;
        OpenColourEdit();
    }
}
