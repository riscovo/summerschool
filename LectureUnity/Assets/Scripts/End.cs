using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class End : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ende");
        SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
        if (other.gameObject.CompareTag("Finish"))
        {
            
            Debug.Log("Ende");
        }


    }
}
