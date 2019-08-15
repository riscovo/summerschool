using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    private static int hit;
    private static bool left1, right1, left2, right2, left3, right3, left4, right4, left5, right5, there;
    public static List<string> names = new List<string>();


    //LeftBools
    public static bool Left1
    {
        get { return left1; }
        set { left1 = value; }
    }

    public static bool Left2
    {
        get { return left2; }
        set { left2 = value; }
    }

    public static bool Left3
    {
        get { return left3; }
        set { left3 = value; }
    }

    public static bool Left4
    {
        get { return left4; }
        set { left4 = value; }
    }

    public static bool Left5
    {
        get { return left5; }
        set { left5 = value; }
    }


    //RightBools
    public static bool Right1
    {
        get {return right1;}
        set {right1 = value; }
    }

    public static bool Right2
    {
        get { return right2; }
        set { right2 = value; }
    }

    public static bool Right3
    {
        get { return right3; }
        set { right3 = value; }
    }

    public static bool Right4
    {
        get { return right4; }
        set { right4 = value; }
    }

    public static bool Right5
    {
        get { return right5; }
        set { right5 = value; }
    }

    public static bool There
    {
        get { return there; }
        set { there = value; }
    }

    public static int Hit
    {
        get
        {
            return hit;
        }
        set
        {
            hit = value;
        }
    }
}
