using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pageonesize : MonoBehaviour
{
    public Text size;

    void Start()
    {
        if(option.fruits == 1)
        {
            size.text = "Big";
        }
        if (option.fruits == 2)
        {
            size.text = "Small";
        }

    }


}
