//Compass controller//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass_controller : MonoBehaviour {

    public Vector3 NorthDirection;
    public Transform Player;
    public Quaternion PathDir;
    public RectTransform North;
    public RectTransform Pathh;
    public Transform PlaceToReach;
	// Update is called once per frame
	void Update () {
        North_fun();
        Mission();
	}
    void North_fun()
    {
        NorthDirection.z = Player.eulerAngles.y;
        North.localEulerAngles = NorthDirection;

    }
    void Mission()
    {
        Vector3 dir = Player.transform.position - PlaceToReach.position;
        //Debug.Log(dir);
        PathDir = Quaternion.LookRotation(-dir);
        PathDir.z = -PathDir.y;
        PathDir.y = 0;
        PathDir.x = 0;
        Pathh.localRotation = (PathDir * Quaternion.Euler(NorthDirection));

    }

}
