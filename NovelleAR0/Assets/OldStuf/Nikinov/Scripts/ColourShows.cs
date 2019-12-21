using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourShows : MonoBehaviour
{
    public Material Mat;
    public Image image;

    private void Update()
    {
        image.color = Mat.color;
    }
}
