using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightThird : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Right3 = true;
            Variables.Hit = 3;
            Debug.Log("FP 3 Right" + Variables.Right3);
        }
    }
}
