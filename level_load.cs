//level scene manager//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class level_load : MonoBehaviour
{
    public GameObject Loading_screen;
    public Slider slider;
    public GameObject level;
    private AsyncOperation async;
    public AudioSource button;
    // Use this for initialization
    public void forest()
    {
        button.Play();
        StartCoroutine(LoadLevel("forest_backup_20-05"));
    }
    public void mine()
    {
        button.Play();
        SceneManager.LoadScene("Mine");
    }
    public void back()
    {
        button.Play();
        SceneManager.LoadScene("menu");
    }
    public IEnumerator LoadLevel(string name)
    {
        level.SetActive(false);
        AsyncOperation operation = SceneManager.LoadSceneAsync(name);
        Loading_screen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }
}
