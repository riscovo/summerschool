using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSecond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Right2 = true;
            Variables.Hit = 2;
            Debug.Log("FP 2 Right" + Variables.Right2);
        }
    }
}
