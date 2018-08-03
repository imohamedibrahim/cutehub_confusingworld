//spamming spell//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spam : MonoBehaviour {

	// Use this for initialization
    public ParticleSystem part;
    public GameObject player;
    public float distance;
    public Text text;
    public int remaining;
    void Start()
    {
        remaining = 11;    
    }
    public void spam()
    {
        if (remaining > 0)
        {
            Instantiate(part, player.transform.position + player.transform.forward * distance, player.transform.rotation);
            remaining--;
        }
    }
    public void Update()
    {
        text.text = remaining.ToString();
        if (remaining == 0)
        {
            text.color = Color.red;
        }
        else
        {
            text.color = Color.black;
        }
    }
}
