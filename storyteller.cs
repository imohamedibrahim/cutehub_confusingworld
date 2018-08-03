//forest story spammer//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class storyteller : MonoBehaviour {
    public Text t;
    int flag=1;
    public GameObject can;
    public GameObject button;
    public void Start()
    {
        button.SetActive(false);

        StartCoroutine(show(flag));
    }
    public void click()
    {
        flag++;
        StartCoroutine(show(flag));
    }
    IEnumerator show(int flag)
    {
        string s1 = "Its almost midnight and we need to soon find the path through this forest before its morning!!!!";
        string s2 = "So lets start!!!!";
        if (flag == 1)
        {
            for (int i = 0; i <s1.Length; i++)
            {
                t.text = s1.Substring(0, i);
                yield return new WaitForSeconds(0.1f);
            }
            button.SetActive(true);
        }
        else if(flag==2) 
        {
            button.SetActive(false);
            t.fontSize = 40;
            for(int j = 0; j < s2.Length; j++)
            {
                t.text = s2.Substring(0, j);
                yield return new WaitForSeconds(0.1f);
            }
            button.SetActive(true);
        }
        else
        {
            //tutorial_controller tc = new tutorial_controller();
            //tc.Start1();
            PlayerPrefs.SetInt("storystatus", 1);
            can.SetActive(false);


        }
    }
}
