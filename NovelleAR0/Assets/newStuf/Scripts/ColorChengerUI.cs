using System.Collections;
using System.Collections.Generic;
using newStuf.Scripts;
using UnityEngine.UI;
using UnityEngine;

public class ColorChengerUI : MonoBehaviour
{
    [SerializeField] private FlexibleColorPicker colorPicker;
    [SerializeField] private Dropdown dropdown;
    public IColorChanger colorChanger;

    public void SetUpDropdown(int ColorsCount)
    {

        List<Dropdown.OptionData> newDropdownData = new List<Dropdown.OptionData>(ColorsCount);

        for (int i = 0; i < ColorsCount; i++)
        {
            Dropdown.OptionData newOptionData = new Dropdown.OptionData();
            newOptionData.text = "Color : " + i;
            newDropdownData.Add(newOptionData);
        }

        dropdown.options = newDropdownData;

    }

    public void OnValueChanged(int newIndex)
    {
        Color newColor = colorChanger.getNewColor(newIndex);
        colorPicker.startingColor = newColor;
        colorPicker.color = newColor;
    }

    public Color getNowColor()
    {
        return colorPicker.color;
    }

    public int getNowIndex()
    {
        return dropdown.value;
    }
}
