using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
    public abstract class Item : Tile
    {
        public Item (int X, int Y, string Symbol = "i") : base (X, Y , Symbol)
        {

        }

        public abstract override string ToString();
    }
}
