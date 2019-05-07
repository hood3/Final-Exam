using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pageonespeed : MonoBehaviour
{
    public Text speed;
    
    void Start()
    {
        speed.text = changeFruitSize.Size.ToString();
    }

    
}

