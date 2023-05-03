using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaningTime : MonoBehaviour
{
    public float timeStart;
    public Text textTimer;
    bool timerRunning = true;

    void Start()
    {
        textTimer.text = timeStart.ToString();
    }
    public void gotoLoss()
    {
        SceneManager.LoadScene("Loss");
    }

    void Update()
    {
        if(timerRunning == true)
        {
            timeStart -= Time.deltaTime;
            textTimer.text = Mathf.Round(timeStart).ToString();
        }
        if (timeStart <0)
        {
            timeStart = 0;
            gotoLoss();
        }
    }
}
