using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftThird : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Variables.Left3 = true;
            Variables.Hit = 3;
            Debug.Log("FP 3 Left" + Variables.Left3);
        }
        
    }
}
