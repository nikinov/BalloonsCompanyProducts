﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    GameObject Spawning;
    private PlacementIndicator indicator;
    private gameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        indicator = FindObjectOfType<PlacementIndicator>();
        manager = FindObjectOfType<gameManager>();
    }
    
    public void Click()
    {
        switch (manager.ModelSelected)
        {
            case 1:
                Spawning = manager.Model1;
                break;
            case 2:
                Spawning = manager.Model2;
                break;
            case 3:
                Spawning = manager.Model3;
                break;
            case 4:
                Spawning = manager.Model4;
                break;
            case 5:
                Spawning = manager.Model5;
                break;
            default:
                Debug.Log("EditMode");
                break;
        }
        if (!manager.EditMode)
        {
            GameObject obj = Instantiate(Spawning, indicator.transform.position, indicator.transform.rotation);
        }
    }
}
