using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{
    public void NextScene()
    {
        Variables.Hit = 0;
        SceneManager.LoadScene("Name", LoadSceneMode.Single);

    }
}
