using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLeft : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Variables.Left = 1;
        Variables.Hit = 1;
        Debug.Log("FP Left" + Variables.Left);
    }
}
