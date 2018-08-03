//tutorial manager//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_controller : MonoBehaviour {

    // Use this for initialization
    public GameObject panel;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;



    // Update is called once per frame
    void Start()
    {
        StartCoroutine(started());
    }
    IEnumerator started()
    {

        yield return new WaitUntil(() => PlayerPrefs.GetInt("storystatus") == 1);
        panel.SetActive(true);
        panel1.SetActive(true);
        b1.SetActive(true);
        if (PlayerPrefs.GetInt("tutorialfinished") == 1)
        {
            // panel.SetActive(true);
            panel1.SetActive(false);
            b1.SetActive(false);
            panel.SetActive(false);
            // Time.timeScale = 1f;

        }
    }
public void click1()
    {
        panel1.SetActive(false);
        b1.SetActive(false);
        PlayerPrefs.SetInt("tutorialfinished",1);
        panel2.SetActive(true);
        b2.SetActive(true);
    }

    public void click2()
    {
        panel2.SetActive(false);
        b2.SetActive(false);
        PlayerPrefs.SetInt("tutorialfinished", 1);
        panel3.SetActive(true);
        b3.SetActive(true);
    }
    public void click3()
    {
        panel3.SetActive(false);
        b3.SetActive(false);
        PlayerPrefs.SetInt("tutorialfinished", 1);
        panel4.SetActive(true);
        b4.SetActive(true);
    }
    public void click4()
    {
        panel4.SetActive(false);
        b4.SetActive(false);
        PlayerPrefs.SetInt("tutorialfinished", 1);
        panel5.SetActive(true);
        b5.SetActive(true);
    }
    public void click5()
    {
        panel5.SetActive(false);
        b5.SetActive(false);
        PlayerPrefs.SetInt("tutorialfinished", 1);
        panel6.SetActive(true);
        b6.SetActive(true);
    }

    public void click6()
    {
        panel6.SetActive(false);
        b6.SetActive(false);
        panel1.SetActive(false);
        Time.timeScale = 1f;
    }
    public void set()
    {
        PlayerPrefs.DeleteAll();
    }
}
