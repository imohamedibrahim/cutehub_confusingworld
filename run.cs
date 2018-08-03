//player run manager //
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class run : MonoBehaviour{
    bool button_press ;
    int count = 0;
    int energy = 100;
    public Image  energy_level;
    public AudioSource walking;
    public float runspeed;
    public Transform player;
    private void Start()
    {
        button_press = false;
        walking.Play();
    }
    public void onPointerUp()
    {
         button_press = true;
        
    
    }
    public void onPointerDown()
    {
        button_press = false;
    }

    void Update()
    {
        energy_level.fillAmount = energy/100f;
        if (button_press == true && energy > 0)
        {
            walking.UnPause();
            if (count % 25 == 0)
            {
                energy=energy-2;
            }
            player.Translate(0, 0, runspeed);
              }
        else
        {
            walking.Pause();
            if ( count % 50 == 0 && energy < 101)
            {
                count = 0;
                energy++;
            }
        }
        count++;
        
    }
}
