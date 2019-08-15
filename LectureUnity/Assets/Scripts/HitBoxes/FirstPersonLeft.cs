using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLeft : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Left1 = true;
            Variables.Hit = 1;
            Debug.Log("FP 1 Left" + Variables.Left1);
        }
    }
}
