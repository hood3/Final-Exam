using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class reading : MonoBehaviour
{
    public Text HighScore;

    void Awake()
    {
        HighScore = GetComponent<Text>();
    }

    void Start()
    {
        StreamReader sr = new StreamReader("Assets/scores.txt");
        HighScore.text = sr.ReadToEnd();
    }
}

