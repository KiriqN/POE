using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    class Shop
    {
        private Weapon [] shopweapons;
        private Character buyer;
        private Random rnd = new Random();

        public Shop (Character consumer)
        {
            consumer = buyer;
            shopweapons = new Weapon[3];
            rnd = new Random();

        }

        private Weapon RandomWeapon()
        {
            int Rweapon = rnd.Next(0, 4);
                
            if (Rweapon == 1)
            {
               // return new MeleeWeapon(MeleeWeapon.Mtypes.Dagger);
            }
            else if (Rweapon == 2)
            {
               // return new MeleeWeapon(MeleeWeapon.Mtypes.Longsword);
            }
            else if (Rweapon == 3)
            {
               // return new RangedWeapon(RangedWeapon.Rtypes.Rifle);
            }
            else if (Rweapon == 4)
            {
               // return new RangedWeapon(RangedWeapon.Rtypes.LongBow);
            }

            return RandomWeapon();

                
        }
    }

}
