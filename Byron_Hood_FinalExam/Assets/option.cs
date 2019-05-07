using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public static int fruits = 0;
    public Dropdown dropdown;
    List<string> fruit = new List<string>() {"please select choice" ,"Big", "small"};

    public void Dropdown_fruitChanged(int index)
    {
        if (index == 1)
        {
            fruits = 1;
        }
        if (index == 2)
        {
            fruits = 2;
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

