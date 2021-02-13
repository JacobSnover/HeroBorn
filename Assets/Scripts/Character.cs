using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int Exp = 0;
    public string Name = string.Empty;

    public Character()
    {
        Name = "Not Assigned";
    }

    public Character(string name)
    {
        Name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.Log($"Hero: {Name} Exp: {Exp}");
    }
}
