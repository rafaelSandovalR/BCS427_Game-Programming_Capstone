using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    
    public void setMax(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    // Update is called once per frame
    public void CurrentHealth(float health)
    {
        slider.value = health;
    }
}
