//destroying  spell source when object is touched//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despammer : MonoBehaviour {
    GameObject script;
    void Start()
    {
        script = GameObject.FindGameObjectWithTag("scripts");
        //Debug.Log(script);
    }
    // Use this for initialization
    public void OnTriggerEnter(Collider collider)

    {
        if (collider.tag == "player")
        {
            //Debug.Log("destrop");
            script.GetComponent<Spam>().remaining++;
            //this.gameObject.transform.position(collider.transform.position);
            Destroy(this.gameObject);
        }
        
    }
}

