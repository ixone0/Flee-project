using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 0f;
    public float timeincrease = 1f;
    public float timeinc = 1f;
    public float totalTime = 180f;
    public float StopTime;
    public bool BoolTime = false; 
    public Text timerText1;
    public Text timerText2;
    public Text timerText3;
    [SerializeField] Text finalTimerText;
    //[SerializeField] TextMeshProUGUI BestScoreText;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer >= totalTime)
        {
            timer = 180;
        }
        
        //timer++;
        if (BoolTime)
        {
            timer += Time.deltaTime;
        }

        /*if (BoolTime = false)
        {
            StopTime = Time.time;
        }*/
        //StartCoroutine(inctime(timeinc,timeincrease));

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText1.text = minutes.ToString("0") + ":" + seconds.ToString("00");
        timerText2.text = minutes.ToString("0") + ":" + seconds.ToString("00");
        timerText3.text = minutes.ToString("0") + ":" + seconds.ToString("00");
    }


    public void CheckBest()
    {
        if(timer < timer)
        {
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            finalTimerText.text = minutes.ToString("0") + ":" + seconds.ToString("00");
        }
    }

/*
    public void CheckBestScore()
    {
        if(timer < PlayerPrefs.GetInt("BestScore", 0))
        {
            PlayerPrefs.SetInt("BestScore", timer);
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            finalTimerText.text = minutes.ToString("0") + ":" + seconds.ToString("00");
        }
    }

    public void UpdateBestScoreText()
    {
        BestScoreText.text = $"{PlayerPrefs.GetInt("BestScore", 0)}";
    }
*/


    /*public IEnumerator inctime(float x,float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if ( timer >= 0 )
            {
                timer += x;
            }

        
        }
      
        */
 }
    

