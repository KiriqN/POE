using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
    class EmptyTile : Tile
    {
        
        public EmptyTile (int X, int Y, string Symbol) : base (X, Y, Symbol)
        {

        }
    }
}
