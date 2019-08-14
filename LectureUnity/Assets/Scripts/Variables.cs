using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    private static int left, right, hit;
    private static string[] name;

    public static int Left
    {
        get
        {
            return left;
        }
        set
        {
            left = value;
        }
    }

    public static int Right
    {
        get
        {
            return right;
        }
        set
        {
            right = value;
        }
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

    public static bool IsName(string n)
    {
        for(int i = 0; i < (name.Length-1); i++)
        {
            if (name[i].Equals(n))
            {
                return true;
            }
        }
        return false;
    }

    public static void SetName(string n)
    {
        int l = name.Length;
        l++;
        string[] name2 = new string[l];
        if(name.Length > 0)
        {
            for(int i = 0; i < (name.Length-1); i++)
            {
                name2[i] = name[i];
            }
        }
        name2[l - 1] = n;
        name = name2;

    }
}
