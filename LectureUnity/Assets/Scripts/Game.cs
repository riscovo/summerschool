using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text input;
    public Text button;

    public void NextScene()
    {
        if (Variables.names.Contains(input.text))
        {
            Debug.Log("ALready there");
            button.text = "Already played";
            Variables.There = true;
        }
        else
        {
            button.text = "Start";
            Variables.names.Add(input.text);
            Variables.There = false;
            Debug.Log("Added");
            SceneManager.LoadScene("Prolog", LoadSceneMode.Single);
        }
    }
}

