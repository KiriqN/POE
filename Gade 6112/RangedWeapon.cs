using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{ 
 class RangedWeapon : Weapon

{
        private Rtypes rifle;

        public enum Rtypes
    {
        Rifle,
        LongBow
    }
    public RangedWeapon(Rtypes rangedTypes, int X, int Y) : base(X, Y)
    {
        x = X;
        y = Y;

        if (rangedTypes == Rtypes.Rifle)
        {
            weaponname = "Rifle";
            durability = 3;
            damage = 5;
            cost = 7;
            range = 3;

        }

        else if (rangedTypes == Rtypes.LongBow)
        {
            weaponname = "LongBow";
            durability = 4;
            damage = 4;
            cost = 6;
            range = 2;
        }


    }

       

        public override string ToString()
    {
        return WeaponName;
    }

}
}
