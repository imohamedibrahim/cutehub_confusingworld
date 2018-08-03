//main menu control manager//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour {
    public AudioSource music;
    public AudioSource button;
    public ParticleSystem snow;
    public void Start()
    {
        music.Play();
        Time.timeScale = 1f;
        snow.Play();
    }
    // Use this for initialization
    public void load_setting()
    {
        button.Play();
        SceneManager.LoadScene("setting");
    }
    public void load_level()
    {
        button.Play();
        SceneManager.LoadScene("levels");
    }
	
	// Update is called once per frame
	public void exit() {
        button.Play();
        Application.Quit();
	}
}
