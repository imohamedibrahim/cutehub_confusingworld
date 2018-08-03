//resetting,volume on and off//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class reset : MonoBehaviour {
    public Button audiobutton;
    // Use this for initialization
    public Sprite music_on;
    public Sprite music_off;
    public GameObject panel;
    public ParticleSystem snow;
    void Start()
    {
        snow.Play();
    }
    public void Update()
    {
        if (PlayerPrefs.GetInt("volume") == 1)
        {
            AudioListener.volume = 0;
            audiobutton.image.sprite = music_off;
        }else
        {
            audiobutton.image.sprite = music_on;
            AudioListener.volume = 1;
        }
    }
    // Update is called once per frame
    public void audio_on_and_off()
    {
        if (PlayerPrefs.GetInt("volume") == 1)
        {
           PlayerPrefs.SetInt("volume", 0);
        }
        else
        {
            PlayerPrefs.SetInt("volume", 1);
        }
    }
    public void back()
    {
        SceneManager.LoadScene("menu");
    }
    public void rese()
    {
        PlayerPrefs.DeleteAll();
        panel.SetActive(false);
    }
    public void cancel()
    {
        panel.SetActive(false);
    }
    public void reset_all()
    {
        panel.SetActive(true);
    }


}
