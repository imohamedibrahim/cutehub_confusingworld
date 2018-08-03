//Code for producing lighting effect//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting_script : MonoBehaviour {
    int i;
    public Light lighting_light;

    public AudioSource thunder_audio;
	// Use this for initialization
	void Start () {
        i = 0;
        lighting_light.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("osssk"+Time.deltaTime);
		if (i  % 300==0 || i %301==0)
        {
           // Debug.Log("in");
            lighting_light.enabled = true;
            
            //i = 0;
        }else if(i %2500 ==0){
            thunder();
            i = 0;
        }
        else
        {
            //Debug.Log("ini");
            lighting_light.enabled = false;
        }
        i++;
	}
    void thunder()
    {
        thunder_audio.Play();
    }
    void thunder_stop()
    {
        thunder_audio.Stop();
    }
}
