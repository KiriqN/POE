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

        public Shop (Character hero)
        {
            this.buyer = hero;
            shopweapons = new Weapon[3];
            rnd = new Random();

            shopweapons = new Weapon[3];
            int random = rnd.Next(0, 4);

            for (int i = 0; i < 3; i++)
            {
                shopweapons[i] = RandomWeapon();
            }

        }

        private Weapon RandomWeapon()
        {
            int Rweapon = rnd.Next(0, 4);
                
            if (Rweapon == 1)
            {
                return new MeleeWeapon(MeleeWeapon.Mtypes.Dagger, 1, 1,"D" );
                
            }
            else if (Rweapon == 2)
            {
                return new MeleeWeapon(MeleeWeapon.Mtypes.Longsword, 1, 1, "7");
            }
            else if (Rweapon == 3)
            {
                return new RangedWeapon(RangedWeapon.Rtypes.Rifle, 1, 1, "R");
            }
            else if (Rweapon == 4)
            {
                return new RangedWeapon(RangedWeapon.Rtypes.LongBow, 1, 1, "1");
            }

            return RandomWeapon();

                
        }

        public bool CanBuy(int num)
        {
            if (buyer.Purse >= shopweapons[num].Cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Buy (int num)
        {
            buyer.Purse -= shopweapons[num].Cost;
            buyer.Pickup(shopweapons[num]);
        }

        public void Randomshopweapons(int index)
        {
            shopweapons[index] = RandomWeapon();
        }
        
        public string DisplayWeapon(int num)
        {

            return $"purchase {shopweapons[0].WeaponName} {shopweapons[0].Cost} Gold \n\n" +
                   $"purchase {shopweapons[1].WeaponName} {shopweapons[1].Cost} Gold \n\n" +
                   $"purchase {shopweapons[2].WeaponName} {shopweapons[2].Cost} Gold \n\n";
        }

        public string BoughtWeapon1 (int num)
        {
            return $" {shopweapons[0]} \n";
                   
        }

        public string BoughtWeapon2(int num)
        {
            return $" {shopweapons[1]} \n";

        }

        public string BoughtWeapon3(int num)
        {
            return $" {shopweapons[2]} \n";

        }
    }

    

}
