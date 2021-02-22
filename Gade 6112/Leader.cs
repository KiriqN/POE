using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    class Leader : Enemy
    {
        private Tile target;

        public Tile Target
        {
            get { return target; }
            set { target = value; }
        }

        public Leader(int X, int Y, string Symbol = "L") : base(X, Y, 2, 20, 20, Symbol)
        {
            if (HP == 0)
                {
                purse = +2;
                }
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.No_Movement)
        {
            throw new NotImplementedException();
        }
    }
}
