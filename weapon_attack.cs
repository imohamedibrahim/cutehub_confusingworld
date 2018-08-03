//Enemy weapon manager on player detecting whether enemy weapon hits player//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class weapon_attack : MonoBehaviour {

    public Text text;
    public Image health;
    int times = 0;
    public string dead_msg;
    bool died = false;
    public Canvas mission_canvas;
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "player")
        {
            times = (int)(health.fillAmount * 5f) - 5;
            times = -times;
            times++;
            if (died == false)
            {
                health.fillAmount = (5 - times)/5f;

            }
            if (times % 5== 0)
            {
                //Debug.Log("in");
                Time.timeScale = 0f;
                times = 0;
                died = true;
                health.color = Color.red;
                mission_canvas.enabled = true;
                text.text = dead_msg;
            }
        }
    }
}
