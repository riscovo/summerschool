using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{
    public Text names;
    public Text button;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            AddName(names.text);
            
        }
    }

    public void AddName(string name)
    {
        if (Variables.names.Count != 0)
        {
            if (Variables.names.Contains(name))
            {
                Debug.Log("ALready there");
                button.text = "Already played";
                Variables.There = true;
            }
            else
            {
                button.text = "Start";
                Variables.names.Add(name);
                Variables.There = false;
                Debug.Log("Added");
                SceneManager.LoadScene("Prolog", LoadSceneMode.Single);
            }
        }
        else
        {
            button.text = "Start";
            Variables.names.Add(name);
            Variables.There = false;
            Debug.Log("Added");
            SceneManager.LoadScene("Prolog", LoadSceneMode.Single);
        }
    }
}
