﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    Text start;

    // Start is called before the first frame update
    void Start()
    {
        start = GetComponent<Text>();
        StartCoroutine(waiter());
        Variables.Left = 0;
        Variables.Right = 0;
        Variables.Hit = 0;

    }

    IEnumerator waiter()
    {
        start.text = "I'll find where she went.";

        //Wait for 4 seconds
        yield return new WaitForSeconds(2);

        start.text = "Oh no, the brakes are not working!";

        //Wait for 2 seconds
        yield return new WaitForSeconds(2);

        //Rotate 20 deg
        start.text = "What am I supposed to do?";

        yield return new WaitForSeconds(2);

        start.text = "No, no, no, it's the crossroads!";

        yield return new WaitForSeconds(2);

        start.text = "";
    }
}
