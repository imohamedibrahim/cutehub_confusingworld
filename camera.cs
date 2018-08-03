//moving camera to get hogging effect//
using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{
    int hog = 0;
    //public GameObject character;
    void update()
    {
        Vector3 cur_pos = transform.position;
        if (hog % 2 == 0)
        {
            cur_pos.y = cur_pos.y + 40;

        }
        else if(hog%3==0)
        {
            cur_pos.y = cur_pos.y - 40; 
        }

        hog++;
       // Debug.Log("in");
        transform.position = Vector3.Lerp(transform.position, cur_pos, 10);
    }
}