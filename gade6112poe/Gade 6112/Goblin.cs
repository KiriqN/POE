using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    [Serializable]
    class Goblin : Enemy
    {
        MovementEnum GoblinMovement;

        public Goblin (int X, int Y, string Symbol = "G") : base (X, Y, 1, 10, 10, Symbol)
        {
            base.purse = 3;
            base.weaponItem = new MeleeWeapon(MeleeWeapon.Mtypes.Dagger, X, Y, "D");
            
        }

        public override void Loot(Character Selectedtarget)
        {
            purse += Selectedtarget.Purse;
        }
        
        public override MovementEnum ReturnMove(MovementEnum goblinmovement = 0)
        {

            return goblinmovement;
                
        }

           

    }

}

