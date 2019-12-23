using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Model0;
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model0Selected;
    public GameObject Model1Selected;
    public GameObject Model2Selected;

    public GameObject Panel0;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Colours;

    public Material mat0;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;

    float WeAreIn;
    int ChangeMat;

    public FlexibleColorPicker picker;

    public void test()
    {
        Debug.Log("it workes");
    }
    public void ReloadScene ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    private void Awake()
    {
        SetModelsFalse();
        SetPanelsFalse();
    }
    void SetModelsFalse ()
    {
        Model0.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);

        Model0Selected.SetActive(true);
        Model1Selected.SetActive(true);
        Model2Selected.SetActive(true);
        WeAreIn = -1;
    }
    void SetPanelsFalse ()
    {
        Panel0.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);

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
            case 2:
                SetPanelsFalse();
                Panel2.SetActive(true);
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
        WeAreIn = 1;
        CheckPanels();
    }
    public void Modl2()
    {
        SetModelsFalse();
        Model2.SetActive(true);
        Model2Selected.SetActive(false);
        WeAreIn = 2;
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
    public void ChengeMat()
    {

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
            case 4:
                mat4.color = picker.color;
                break;
            case 5:
                mat5.color = picker.color;
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
    public void ChangeMat4()
    {
        ChangeMat = 4;
        OpenColourEdit();
    }
    public void ChangeMat5()
    {
        ChangeMat = 5;
        OpenColourEdit();
    }
    public void delete()
    {
        switch (WeAreIn)
        {
            case 0:
                Model0.GetComponent<EditMode>().Desstroy();
                break;
            case 1:
                Model1.GetComponent<EditMode>().Desstroy();
                break;
            case 2:
                Model2.GetComponent<EditMode>().Desstroy();
                break;
            default:
                Debug.Log("Error in WeAreIn");
                break;
        }
    }
}
