using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeMode : MonoBehaviour
{
    public ContentPositioningBehaviour behaviour;
    public GameObject Multi;
    public GameObject Single;

    private void Awake()
    {
        behaviour.DuplicateStage = false;
        Single.SetActive(true);
        Multi.SetActive(false);
    }
    public void Change()
    {
        if (behaviour.DuplicateStage == true)
        {
            behaviour.DuplicateStage = false;
            Single.SetActive(true);
            Multi.SetActive(false);
        }
        else if (behaviour.DuplicateStage == false)
        {
            behaviour.DuplicateStage = true;
            Single.SetActive(false);
            Multi.SetActive(true);
        }
    }
}
