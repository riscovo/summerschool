using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prolog : MonoBehaviour
{
    Text prolog;
    private int dialog;

    // Start is called before the first frame update
    void Start()
    {
        prolog = GetComponent<Text>();

        prolog.text = "Radio: Teenagers are already gathering in front of the town hall to protest against Chemotex, who intends to invest " +
            "millions here in Suntown to build their factory just behind...";
        dialog = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            dialog++;
            switch (dialog)
            {
                case 2: prolog.text = "Mom, all my classmates are there, I really want to go!";
                    break;
                case 3: prolog.text = "I already said no. I need help with your little brother.";
                    break;
                case 4: prolog.text = "Father would let me.";
                    break;
                case 5: prolog.text = "If tombstones could talk, his would also say no. (Even if your father were here, he would also say no.)";
                    break;
                case 6: prolog.text = "Mom! Why are you always so insensitive!";
                    break;
                case 7: prolog.text = "That's life. ... Wait, where do you think you are going?!";
                    break;
                case 8: prolog.text = "To demonstrate!";
                    break;
                case 9: prolog.text = "Now you wait just a second...!";
                    break;
                case 10: prolog.text = "*Door smash, clatter of the footsteps on the pavement outside*";
                    break;
                case 11: prolog.text = "Oh, shhh, don't cry Timmy, shhh. Don't worry, we'll go and get your mean sister. I'll just ready the car.";
                    break;
                case 12: SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                    break;
            }
        }
    }
}
