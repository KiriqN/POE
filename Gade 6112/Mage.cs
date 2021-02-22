using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    [Serializable]
    class Mage : Enemy
    {
        
        MovementEnum MageMovement;

        public Mage (int X, int Y, string Symbol = "M") : base(X, Y, 5, 5, 5, Symbol)
        {
            if (HP == 0)
            {
                purse = +3;
            }
        }



        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.No_Movement)
        {
           
          
            
            MageMovement = MovementEnum.No_Movement;
            

            return MageMovement;
        }

    }

   
}


