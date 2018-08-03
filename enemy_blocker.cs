//block enemy to get inside home//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_blocker : MonoBehaviour {

    // Use this for initialization
    
    public static bool can_chase;
    // Update is called once per frame
    public void Start()
    {
        can_chase = true;
    }
    public static bool get_can_chase()
    {
        return can_chase;

    }
    public static void set_can_chase(bool set)
    {
        can_chase = set;
    }
}
