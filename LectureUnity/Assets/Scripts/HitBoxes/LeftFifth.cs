using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftFifth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Variables.Left5 = true;
            SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
        }

    }
}
