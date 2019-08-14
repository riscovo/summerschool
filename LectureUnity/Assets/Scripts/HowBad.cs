using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowBad : MonoBehaviour
{
    Text bad;

    private int good, good2;

    // Use this for initialization
    void Start()
    {
        bad = GetComponent<Text>();
        good = Variables.Right;
        good2 = Variables.Left;

        if (good == 0 & good2 == 0)
        {
            bad.text = "You cheeeated!!!";
        }
        else
        {
            switch (good)
            {
                case 0:
                    bad.text = "Everyone is shocked by the horrific accident but while they try to act sympathetic towards your tragic end, in" +
                        "  their homes some people whisper about you as a 'racist pig', better of dead. Your neighbour, devastated by the loss of" +
                        "his two children drinks himself to the egde of his sanity. In a vengeful act he sets your empty house on fire, accidently" +
                        " burning his own house down as well, with his wife still inside. There is a funeral for you and little Timmy, half of the" +
                        " town having come to say goodbye. Your daughter is sitting in the front row, tears streaming down her cheeks, the social" +
                        " worker waiting by the door for her. She will spend the rest of her youth in an orphanage and have become a prostitue by" +
                        " the age of 18, eventually dying of AIDS two years later.";
                    break;
                case 1:
                    bad.text = "What did those old ladys ever do to you?!";
                    break;
                case 2:
                    bad.text = "Well, you did not like them about equally.";
                    break;
                case 3:
                    bad.text = "It seems you prefer guys over girls.";
                    break;
                case 4:
                    bad.text = "Apparently that one lady was just really slow.";
                    break;
                case 5:
                    bad.text = "You are devastasted by the events. The whole town looks down upon you and you are despised by the strong LGBTQ" +
                        " community in the city, hated by otheres. Your co-workers call you a 'homophobic caveman'. NO one cares about the future" +
                        " of Suntown anymore, no one protests against Chemotox anymore so they will build their facility, polluting the groundwater" +
                        " and the soil in the process. This will result in the forced eviction of the whole Suntown leaving it completely abandoned" +
                        " by the time four years have passed. You're opening a sad chapter of your life. There is a picture of your daughter hanging" +
                        " above the fireplace, forever reminding you of your last words to her and leaving you hopeless and miserable with the knowledge" +
                        " that some things can not be undone. So you pour all your sadness and anger into your growing baby, who will grow up to be an" +
                        " irresponsible punk, only to die at the age of 17 by a drug overdose.";
                    break;

            }
        }
    }
}
