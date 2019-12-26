using System;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    [SerializeField] private GameObject selectedIndicator;
    public Material Out;
    float Thiss = .03f;

    private void Start()
    {
        selectedIndicator.SetActive(false);
    }

    public void Selected()
    {
        if(selectedIndicator != null)
            selectedIndicator.SetActive(true);
        Out.SetFloat(" _Scalee", Thiss);
    }
    
    public void Deselected()
    {
        if(selectedIndicator != null)
            selectedIndicator.SetActive(false);
    }

}
    