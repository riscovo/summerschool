using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFourth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Variables.Right4 = true;
            Variables.Hit = 4;
            Debug.Log("FP 4 Right" + Variables.Right4);
        }

    }
}
