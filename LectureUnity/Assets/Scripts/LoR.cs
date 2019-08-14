using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Variables.Left++;

        Debug.Log("Left" + Variables.Left);
    }
}
