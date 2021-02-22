using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
    public abstract class Enemy : Character
    {
      public Enemy (int X, int Y, int Damage, int HP, int MaxHP, string Symbol) : base (X, Y, Symbol)
        {
            Random rnd = new Random();
            int enemymove = rnd.Next(1, 4);

            this.hp = HP;
            this.maxhp = MaxHP;
        }

        public override string ToString()
        {
            return "(Enemy at [{X}, {Y}] has taken [{Damage}] damage)";
        }
    }

}
