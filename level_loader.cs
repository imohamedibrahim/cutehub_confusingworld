//level unlocking //
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class level_loader : MonoBehaviour
{
    int level;
    public GameObject level1;
    public Button level1_button;
    public Button level2_button;
    public GameObject level2;
    // Use this for initialization
    void Start()
    {
        level1_button.interactable = false;
        level2_button.interactable = true;
        level = PlayerPrefs.GetInt("level_completed");
        if (level == 1)
        {
            level1_button.interactable = true;
            level1.SetActive(false);
        }
        else if (level == 2)
        {
            level1_button.interactable = true;
            level2_button.interactable = true;
            level2.SetActive(false);
            level1.SetActive(false);
        }
    }
}
