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
            Longsword
        }
        public MeleeWeapon(Mtypes meleeTypes, int X, int Y) : base(X, Y)
        {
            

            
            

            if (meleeTypes == Mtypes.Dagger)
            {
                weaponname = "Dagger";
                durability = 10;
                damage = 3;
                cost = 3;
                

            }

            else if (meleeTypes == Mtypes.Longsword)
            {
                weaponname = "LongSword";
                durability = 6;
                damage =4;
                cost = 5;
            }

            
    }

      
        

        public override string ToString()
        {
            return WeaponName;
        }

    }
}

    

