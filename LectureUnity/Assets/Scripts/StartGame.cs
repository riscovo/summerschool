using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("return"))
        {
            print("enter key is held down");
            SceneManager.LoadScene("Name", LoadSceneMode.Single);
        }
    }
}
