using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSecond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Left2 = true;
            Variables.Hit = 2;
            Debug.Log("FP 2 Left" + Variables.Left2);
        }
    }
}
