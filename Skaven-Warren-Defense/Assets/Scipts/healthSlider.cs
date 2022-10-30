using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    
    public void setMax(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    // Update is called once per frame
    public void CurrentHealth(int health)
    {
        slider.value = health;
    }
}
