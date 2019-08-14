using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Variables.Right++;

        Debug.Log( "Right" + Variables.Right);
    }
}
