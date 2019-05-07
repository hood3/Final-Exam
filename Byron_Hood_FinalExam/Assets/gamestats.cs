using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class gamestats : MonoBehaviour
{
    public Text HighStats;
    void Awake()
    {
        HighStats = GetComponent<Text>();
    }

    void Start()
    {
        HighStats.text = "Name: " + PlayerPrefs.GetString("Player")+ " Score: " + ScoreKeeper.newScore.ToString()+" Lives :"+ LivesTracker.lives.ToString();

    }

    
    
}
