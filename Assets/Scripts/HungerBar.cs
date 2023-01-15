using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHungerStatus(int hungerStatus)
    {
        slider.maxValue = hungerStatus;
        slider.value = 0.0f;
    }

    public void SetHungerStatus(int hungerStatus)
    {
        slider.value = hungerStatus;
    }
}