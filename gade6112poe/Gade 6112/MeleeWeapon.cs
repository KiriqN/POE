using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    class MeleeWeapon : Weapon
    {
        private Mtypes dagger;

        public enum Mtypes
        {
            Dagger,
            Longsword,
            Bare_Hands
        }
        public MeleeWeapon(Mtypes meleeTypes, int X, int Y, string Symbol) : base(Symbol, X, Y)
        {
         

            if (meleeTypes == Mtypes.Dagger)
            {
                weaponname = "Dagger";
                durability = 10;
                damage = 3;
                cost = 3;
                range = 1;
                

            }

            else if (meleeTypes == Mtypes.Longsword)
            {
                weaponname = "LongSword";
                durability = 6;
                damage = 4;
                cost = 5;
                range = 1;
            }

            else if (meleeTypes == Mtypes.Bare_Hands)
            {
                weaponname = "Bare Hands";
                range = 1;
            }

            
    }

      
        

        public override string ToString()
        {
            return WeaponName;
        }

    }
}

    

