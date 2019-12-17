using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour
{
    public SpawnTheObjects spawn;
    public GameObject Multi;
    public GameObject Single;
    public GameObject Add;
    public GameObject Edit;
    //testing eddit mode does not do enything
    public bool EditModeTest;

    private void Awake()
    {
        spawn.isDuplicating = false;
        Single.SetActive(true);
        Multi.SetActive(false);
        Edit.SetActive(false);
    }
    public void Change()
    {
        if (spawn.isDuplicating == true)
        {
            spawn.isDuplicating = false;
            Single.SetActive(true);
            Multi.SetActive(false);
        }
        else if (spawn.isDuplicating == false)
        {
            spawn.isDuplicating = true;
            Single.SetActive(false);
            Multi.SetActive(true);
        }
    }
    public void EditMode()
    {
        if (EditModeTest == true)
        {
            EditModeTest = false;
            Add.SetActive(true);
            Edit.SetActive(false);
        }
        else if (EditModeTest == false)
        {
            EditModeTest = true;
            Add.SetActive(false);
            Edit.SetActive(true);
        }
    }
}
