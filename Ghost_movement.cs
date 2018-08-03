//This is dropped code//
//Conrolling the enemy random movement//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_movement : MonoBehaviour
{
    Vector3 pos;
    Vector3 directionOfCharacter;
    int hide = 0;
    bool triggered = false;
    public GameObject ghost;
    public Transform target;
    // Use this for initialization
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float num_random = Random.Range(0f, 1f);
        if (triggered  && hide%50==0)
        {
            directionOfCharacter = target.transform.position - transform.position;
            directionOfCharacter = directionOfCharacter.normalized;    // Get Direction to Move Towards
            transform.Translate(new Vector3(directionOfCharacter.x%2,directionOfCharacter.y%2,directionOfCharacter.z%2), Space.World);
        }
        //int num = (int)num_random * 100;
        if (hide % 20 == 0)
        {
            ghost.SetActive(false);

        }
        else if (hide % 28 == 0)
        {
            ghost.SetActive(true);
        }
        if (hide > 1500)
        {
            hide = 0;
        }
        hide++;
        Move(num_random, pos);
    }
    void Move(float num, Vector3 pos)
    {
        // Debug.Log(num);
        if (num < 0.98)
        {
            move_direction_straight(pos);
        }
        else if (num >= 0.98 && num < 0.99)
        {
            move_direction_right(pos);
        }
        else if (num >= 0.99 && num < 1.0)
        {
            move_direction_left(pos);
        }

    }
    void move_direction_straight(Vector3 pos)
    {
        //ghost.enabled = true;
        this.transform.transform.Translate(2 * Time.deltaTime, 0, 0);
    }
    void move_direction_right(Vector3 pos)
    {
        this.transform.Rotate(new Vector3(0, 90, 0));

    }
    void move_direction_left(Vector3 pos)
    {
        //this.enabled = false;
        this.transform.transform.Rotate(0, -90, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")

        {
            triggered = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}