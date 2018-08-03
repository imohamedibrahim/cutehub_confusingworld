//mine level story spammer//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class storyofmine : MonoBehaviour
{
    public Text t;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Show(0));
    }

    // Update is called once per frame
    private IEnumerator Show(int flag)
    {
        string s1 = "And we are almost escaped....... Now Let's find the path through this mine!!!!";
        for (int i = 0; i < s1.Length; i++)
        {
            t.text = s1.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
