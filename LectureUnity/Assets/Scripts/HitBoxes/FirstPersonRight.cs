using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonRight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.name == "Player")
        {
            Variables.Right1 = true;
            Variables.Hit = 1;
            Debug.Log("FP 1 Right" + Variables.Right1);
        }
    }
    
}
