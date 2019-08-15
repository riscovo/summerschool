using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowBad : MonoBehaviour
{
    Text bad;

    private int dialog;

    // Use this for initialization
    void Start()
    {
        bad = GetComponent<Text>();

       
        bad.text = "All the citizens of Suntown are shocked by the tragic events that happened to your family. Most of the people try to act" +
            " sympathetic when speaking about it but behind the scenes, int he safety of their homes they whisper about you as";
    }

    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            dialog++;
            switch (dialog)
            {
                case 2:
                    if (Variables.Right3 == true)
                    {
                        bad.text = "a 'homophobic cavewoman'. The LGBTQ community in Suntown is furious, a heated conflict ensues and finally results in a riot.";
                    }
                    else
                    {
                        bad.text = "'the racist pig'. The whole Afro-American community in Suntown is furious, a heated conflict ensues and finally results in a riot.";
                    }
                    break;
                case 3:
                    if (Variables.Right2 == true)
                    {
                        bad.text = "The policeman manages to settle the conflict in just a day, but the seven people injured during the riot do not get any medical" +
                            " help in time and die before the second day comes.";
                    }
                    else
                    {
                        bad.text = "Since there is no policeman it takes several days to settle the riot. Despite the best effort of the doctor six people die during the riot.";
                    }
                    break;
                case 4:
                    if (Variables.Right4 == true)
                    {
                        bad.text = "No one protest for the future of Suntown anymore and Chemotox will build their facility, polluting the ground water and the soil in the" +
                                " process. This results in the eviction of the whole city of Suntown, making it completely abandoned int less than four years.";
                    }
                    else
                    {
                        bad.text = "Your neighbour, devastated by the death of his two children, drinks himself to the egde of his sanity. In the process of trying to set" +
                                " your house on fire he accidentally burns down his own place instead with his wife still inside.";
                    }
                    break;
                case 5:
                    if (Variables.Right5 == true)
                    {
                        bad.text = "You open a sad chapter of your life. There is a picture of your daughter hanging above the fireplace, forever reminding you of the last words" +
                                " you said to her, leaving you hopeless and miserable as some things cannot be undone. You pour all your sadness and anger into your baby, who will" +
                                " grow up to be an irresponsible punk, dying of an overdose at the age of 17.";
                    }
                    else
                    {

                        bad.text = "There is a funeral for you and little Timmy and half of the town has come to say goodbye. Your daughter is sitting in the front row, tears" +
                                " streaming down her face as the social worker is waiting at the door for her. She will spend the rest of her youth in an orphanage and will have" +
                                " become a prostitute by the age of 18. Three years later she will eventually be choked to death by an unsatisfied customer.";
                    }
                    break;
                case 6:
                    if (Variables.Right1 == true)
                    {
                        bad.text = "And by the way... there are no burgers in Suntown anymore.";
                    }
                    else
                    {
                        bad.text = "And by the way... there is no icecream in Suntown anymore.";
                    }
                    break;
                case 7: SceneManager.LoadScene("Name", LoadSceneMode.Single);
                    break;
            }
        }
    }
}
