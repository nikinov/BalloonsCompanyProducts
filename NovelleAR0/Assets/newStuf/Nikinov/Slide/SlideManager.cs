using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    public float timer;
    public Scrollbar slider0;
    public Scrollbar slider1;
    public bool chek;

    private void FixedUpdate()
    {
        if (!chek)
        {
            if (slider0.value <= .5f)
            {
                if (slider0.value > 0.01)
                {
                    slider0.value -= .5f;
                }
            }
            else if (slider0.value > .5f)
            {
                if (slider0.value < 0.99)
                {
                    slider0.value += .5f;
                }
            }
            if (slider1.value <= .5f)
            {
                if (slider1.value > 0.01)
                {
                    slider1.value -= .5f;
                }
            }
            else if (slider1.value > .5f)
            {
                if (slider1.value < 0.99)
                {
                    slider1.value += .5f;
                }
            }
        }
        if (timer > 0)
        {
            timer -= 2;
        }
        if (timer <= 0.1)
        {
            chek = false;
        }
        if (timer > 20)
        {
            timer = 20;
        }
    }
    public void BringUpMenu0 (float val)
    {
        chek = true;
        timer += 10;
    }
    public void BringUpMenu1 (float val)
    {
        chek = true;
        timer += 10;
    }
}
