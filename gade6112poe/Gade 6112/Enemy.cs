using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
     abstract class Enemy : Character
    {
        protected Random enemymove = new Random();
      public Enemy (int X, int Y, int Damage, int HP, int MaxHP, string Symbol) : base (X, Y, Symbol)
        {
            Random rnd = new Random();
            int enemymove = rnd.Next(1, 4);

            hp = HP;
            maxhp = MaxHP;
            damage = Damage;
        }

        public override string ToString()
        {
            return $"Enemy Stats:\nHP: {this.hp}/{this.MaxHP} \nDamage: {this.damage}" +
                   $" \n[{this.x}, {this.y}]  " +
                   $"Gold: { this.purse} \n " +
                   $"Current Weapon: {weaponItem.WeaponName} \n ";
                   
                   
        }
    }

}
