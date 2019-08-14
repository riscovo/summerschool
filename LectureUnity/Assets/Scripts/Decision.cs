using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decision : MonoBehaviour
{
    public GameObject go;
    public GameObject tet;
    public Text ouch;
    public Text right;
    public Text left;

    public float speed2;
    public float speed3;

    private float time;

    // Update is called once per frame
    void Update()
    {
        if (go.activeSelf == true)
        {
            time = tet.GetComponent<Timer>().targetTime;
            if (time < 0.7)
            {
                ouch.text = "OUCH!!!";
            }
            if (time < 0)
            {
                EnableCanvas(go);
                GameObject.Find("Player").GetComponent<Movement>().moveVertical = speed3;
                ouch.text = "";
                tet.GetComponent<Timer>().targetTime = 7.0f;

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").GetComponent<Movement>().moveVertical = speed2;
        DisableCanvas(go);
        Debug.Log("Hits:" + Variables.Hit);
        switch (Variables.Hit)
        {
            case 0: left.text = "Elderly person";
                right.text = "Child";
                Variables.Hit = 1;
                break;
            case 1: left.text = "Doctor";
                right.text = "Policeman";
                Variables.Hit = 2;
                break;
            case 2: left.text = "Black heterosexual";
                right.text = "White homosexual";
                Variables.Hit = 3;
                break;
            case 3: left.text = "Two of your neighbours little children";
                right.text = "Four teenagers with signs and banners";
                Variables.Hit = 4;
                break;
            case 4: left.text = "You and your baby";
                right.text = "Your daughter";
                Variables.Hit = 5;
                break;
        }
        Debug.Log("Hits:" + Variables.Hit);

    }

    void DisableCanvas(GameObject c)
    {
        c.SetActive(true);
    }

    void EnableCanvas(GameObject c)
    {
        c.SetActive(false);
    }
}