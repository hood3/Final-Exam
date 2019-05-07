using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int playTime = 0;
    public static int seconds = 0;
    public static int minutes = 0;
    public Text TimeText;

    void Start()
    {
        StartCoroutine("Playtimer");
    }

    private IEnumerator Playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playTime += 1;
            seconds = (playTime % 60);
            minutes = (playTime / 60);
        }
    }

    void Update()
    {
        TimeText.text = "Time: " + minutes.ToString() + ": " + seconds.ToString();
        if(options2.fruitsTwo == 1 && playTime == 120)
        {
           SceneManager.LoadScene("4Exit");
        }
      //  if (TimeControl.time == 2 && playTime == 180)
      //  {
         //   SceneManager.LoadScene("End");
       // }
    }
}

