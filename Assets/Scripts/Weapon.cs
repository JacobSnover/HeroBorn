using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    public string Name;
    public int Damage;

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon {Name} - {Damage} DMB");
    }
}
