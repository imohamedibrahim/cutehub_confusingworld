//blocking enemy when player enters the shelter//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelter : MonoBehaviour {
    public void Start()
    {
        enemy_blocker.set_can_chase(true);
    }
    // Use this for initialization
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            enemy_blocker.set_can_chase(false);
            Debug.Log("inside_shelter");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            Debug.Log("out_of_shelter");
            enemy_blocker.set_can_chase(true);
        }
    }
}
