//camera hog effect manager//
using UnityEngine;
using System.Collections;

public class Cam_hog : MonoBehaviour
{
    int hog = 0;
    bool enter;
    public Light directional;
    Vector3 cur_pos,ini_pos;
    //public GameObject character;
    void Start()
    {
       // Debug.Log("OIJIJ");
        enter = true;
        directional.enabled = false;
        ini_pos = this.transform.localPosition;
    }
    void Update()
    {
        //Debug.Log("in");
        cur_pos = this.transform.localPosition;

        if (hog < 40 && hog >= 0)
        {
            if (enter)
            {
               // Debug.Log("1");
                cur_pos.y = cur_pos.y + 0.001f;
                // enter = false;
                // this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, cur_pos,500f);
                this.transform.localPosition = cur_pos;
            }
        }
        else if (hog >40 || hog <0)
        {
           // Debug.Log("2");
            cur_pos.y = cur_pos.y - 0.001f;
            //this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, cur_pos, 500f);
            this.transform.localPosition = cur_pos;
            
           // enter = true;

        }
        if (hog == 80)
        {
            hog = -1;
        }
        hog++;

    }
}