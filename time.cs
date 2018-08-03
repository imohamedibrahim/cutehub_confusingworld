//time managing //
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

    // Use this for initialization
    public Text count;
    public Text end;
    float rem =3100;
    public Canvas canva;
	// Update is called once per frame
	void Update () {
        if (rem <= 0)
        {
            canva.enabled=true;
            end.text= "Time up!!";
            return;
        }
        rem = rem - 0.1f*Time.timeScale;
        //Debug.Log(Time.timeScale);
        count.text = rem.ToString("F2");
        if (rem < 100)
        {
            count.color = Color.red;
        }
        else
        {
            count.color = Color.white;
        }
	}
}
