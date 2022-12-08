using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaSlider : MonoBehaviour
{
    public Slider slider;
    private GameObject play;
    //private PlayerMagicSystem magic = play.GetComponent<PlayerMagicSystem>();

    void Start()
    {
        play = GameObject.FindWithTag("Player");
        setMax(play.GetComponent<PlayerMagicSystem>().maxMana);
        CurrentMana(play.GetComponent<PlayerMagicSystem>().maxMana);
    }

    void Update()
    {
        CurrentMana(play.GetComponent<PlayerMagicSystem>().maxMana);
    }

    public void setMax(float mana)
    {

        slider.maxValue = mana;
        slider.value = mana;
    }

    public void CurrentMana(float mana)
    {
        slider.value = mana;
    }
}
