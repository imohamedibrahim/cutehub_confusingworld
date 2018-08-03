//when a level completed//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission_tick : MonoBehaviour {
    public Canvas mission_canvas;
	// Use this for initialization
	public void tickOK()
    {
        Time.timeScale = 1f;
        mission_canvas.enabled = false;

    }
}
