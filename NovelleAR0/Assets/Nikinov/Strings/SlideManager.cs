using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    public float timer;
    public Slider slider0;
    public Slider slider1;
    public bool chek;

    private void FixedUpdate()
    {
        Debug.Log("slid" + slider0.value);
        if (!chek)
        {
            if (slider0.value <= .5f)
            {
                if (slider0.value > 0)
                {
                    slider0.value -= .5f;
                }
            }
            if (slider0.value > .5f)
            {
                if (timer < 20)
                {
                    slider0.value += .5f;
                }
            }
            if (slider1.value <= .5f)
            {
                if (slider1.value > 0)
                {
                    slider1.value -= .5f;
                }
            }
            if (slider1.value > .5f)
            {
                if (timer < 20)
                {
                    slider1.value += .5f;
                }
            }
        }
        if (timer > 0)
        {
            timer -= 70 * Time.deltaTime;
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
