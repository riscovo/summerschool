using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFifth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Right5 = true;
            Variables.Hit = 5;
            Debug.Log("FP 5 Right" + Variables.Right5);
        }
    }
}
