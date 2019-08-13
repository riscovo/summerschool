using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour
{
    public GameObject go;
    public GameObject tet;
    public GameObject tex;

    public float speed2;
    public float speed3;

    private float time;

    // Update is called once per frame
    void Update()
    {
        if (go.activeSelf == true)
        {
            time = tet.GetComponent<Timer>().targetTime;
            if (time < 0)
            {
                EnableCanvas();
                GameObject.Find("Player").GetComponent<Movement>().moveVertical = speed3;
                EnableText();
                Example();
                DisableText();
                tet.GetComponent<Timer>().targetTime = 7.0f;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").GetComponent<Movement>().moveVertical = speed2;
        Debug.Log("Sie");
        DisableCanvas();

    }

    IEnumerator Example()
    {
        print(Time.time);
        Debug.Log("Sie");
        yield return new WaitForSeconds(2);
        Debug.Log("Sie");
        print(Time.time);
    }

    void DisableCanvas()
    {
        go.SetActive(true);
        Debug.Log("Sie");
    }

    void EnableCanvas()
    {
        go.SetActive(false);
    }

    void EnableText()
    {
        tex.SetActive(true);
    }

    void DisableText()
    {
        tex.SetActive(false);
    }
}