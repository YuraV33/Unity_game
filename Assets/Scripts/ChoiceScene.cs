using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ChoiceScene : MonoBehaviour
{
    public int cristals;
    public Text TextCristals;

    public void LoadSceneMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSceneLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadSceneAuthor()
    {
        SceneManager.LoadScene(9);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Exit1"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.CompareTag("Cristal"))
        {
            cristals++;
            other.gameObject.SetActive(false);
            TextCristals.text = cristals.ToString();
        }
    }
}
