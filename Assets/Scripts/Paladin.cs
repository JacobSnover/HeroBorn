using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Paladin : Character
    {
        public Weapon Weapon;

        public Paladin(string name, Weapon weapon) : base(name)
        {
            Weapon = weapon;
        }

        public override void PrintStatsInfo()
        {
            Debug.Log($"Hail {Name} - take up your {Weapon.Name}");
        }
    }
}
