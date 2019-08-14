using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{
    public void NextScene()
    {
        Variables.Left = 0;
        Variables.Right = 0;
        Variables.Hit = 0;
        SceneManager.LoadScene("Name", LoadSceneMode.Single);

    }
}
