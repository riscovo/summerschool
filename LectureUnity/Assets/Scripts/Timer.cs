using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float targetTime = 60.0f;

    Text instruction;

    // Use this for initialization
    void Start()
    {
        instruction = GetComponent<Text>();
        
    }

    void Update()
    {

        targetTime -= Time.deltaTime;
        instruction.text = ((int)targetTime).ToString();

    }


}
