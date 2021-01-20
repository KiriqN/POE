﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class MeleeWeapon : Weapon
    {
        public enum MeleeWeapons
        {
            Dagger, 
            LongSword
        }
       
        //public contrusctor for Dagger and Longsword

        public MeleeWeapon(WeaponType Type , string Symbol, int _posx = 1, int _posy = 1 ) : base(Symbol, _posx, _posy)
        {
            
            if (Type == WeaponType.Dagger)
            {
                
                base.Durability = 10;
                base.Cost = 3;
                base.Damage = 3;
                base.Range = 1;
                base.typeWeapon = "Dagger";
                base.Type = WeaponType.Dagger;

            }
            if (Type == WeaponType.LongSword)
            {
                
                base.Durability = 6;
                base.Cost = 5;
                base.Damage = 4;
                base.Range = 1;
                base.typeWeapon = "Longsword";
                base.Type = WeaponType.LongSword;
            }

            weaponType = Type;

        }

        public WeaponType weaponType;

        public override string ToString()
        {
            return "MeleeWeapon at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ")";
        }
    }
}
