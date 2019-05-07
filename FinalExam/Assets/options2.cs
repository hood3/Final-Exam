using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class options2 : MonoBehaviour
{
    public static int fruitsTwo = 0;
    public Dropdown dropdown;
    List<string> fruit = new List<string>() { "please select choice", "2minutes", "unlimited" };

    public void Dropdown_fruitChanged(int index)
    {
        if (index == 1)
        {
            fruitsTwo = 1;
        }
        if (index == 2)
        {
            fruitsTwo = 2;
        }

    }

    void Start()
    {
        PopulateFruit();
    }

    void PopulateFruit()
    {
        dropdown.AddOptions(fruit);
    }
}


