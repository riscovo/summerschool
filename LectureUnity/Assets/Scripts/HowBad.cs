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
                    bad.text = "Let me guess: you don't really like old people.";
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
                    bad.text = "You have something against guys, don't you?";
                    break;

            }
        }
    }
}
