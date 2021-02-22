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
            if (HP == 0)
            {
                purse = +1;
            }
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.No_Movement)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            if (random == 1)
            {
                GoblinMovement = MovementEnum.Up;
            }

            else if (random == 2)
            {
                GoblinMovement = MovementEnum.Down;
            }

            else if (random == 3)
            {
                GoblinMovement = MovementEnum.Right;
            }
            
            else if (random == 4)
            {
                GoblinMovement = MovementEnum.Left;
            }

            else if (random == 5)
            {
                GoblinMovement = MovementEnum.No_Movement;
            }

            return GoblinMovement;
        }
    }
}
