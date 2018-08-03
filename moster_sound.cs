//code for managing enemy sound//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moster_sound : MonoBehaviour {
    public AudioSource sound;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime != 0f)
        {
            sound.UnPause();
        }
        else
        {
            sound.Pause();
        }
	}
}
