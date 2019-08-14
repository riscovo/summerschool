using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public InputField input;
    public Button button;

    public void NextScene()
    {
        /*if (Variables.IsName(input.GetComponentInChildren<Text>().text))
        {
            button.GetComponentInChildren<Text>().text = "Already played";
        }
        else
        {
            SceneManager.LoadScene("Prolog", LoadSceneMode.Single);
        }*/

        SceneManager.LoadScene("Prolog", LoadSceneMode.Single);

    }
}
