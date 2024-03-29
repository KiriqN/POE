﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
   abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponname;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public int Durability
        {
            get { return durability;  }
            set { durability = value; }
        }

        public int Cost
        {
            get { return cost;  }
            set { cost = value; }
        }

        public string WeaponName
        {
            get { return weaponname;  }
        }

        public Weapon (string weaponSymbol, int X, int Y) : base ( X, Y, weaponSymbol)
        {
            this.type = TileType.Weapon;
        }
    }
}
