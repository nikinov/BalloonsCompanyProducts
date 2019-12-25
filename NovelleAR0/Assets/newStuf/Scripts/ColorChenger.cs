using System;
using System.Collections;
using System.Collections.Generic;
using newStuf.Scripts;
using UnityEngine;

public class ColorChenger : MonoBehaviour,IColorChanger
{
    private bool _isChengingColor;
    FlexibleColorPicker picker;

    public bool IsChengingColor
    {
        get => _isChengingColor;
        set => _isChengingColor = value;
    }

    private MaterialHandler materialHandler;
    [SerializeField] private ColorChengerUI chengerUi;

    private void Awake()
    {
        chengerUi.colorChanger = this;
        picker = FindObjectOfType<FlexibleColorPicker>();
    }

    public void setUpChenger(GameObject selected)
    {
        materialHandler = selected.GetComponent<MaterialHandler>();
        if (materialHandler == null)
        {
            materialHandler = selected.GetComponentInChildren<MaterialHandler>();
        }
        
        chengerUi.SetUpDropdown(materialHandler.Length());
        _isChengingColor = true;
    }

    public Color getNewColor(int index)
    {
        return materialHandler.GetMaterial(index).color;
    }

    private void Update()
    {
        if (_isChengingColor)
        {
            materialHandler.GetMaterial(chengerUi.getNowIndex()).color = picker.color;
        }
    }
}
