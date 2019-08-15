using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFourth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Left4 = true;
            Variables.Hit = 4;
            Debug.Log("FP 4 Left" + Variables.Left4);
        }
    }
}
