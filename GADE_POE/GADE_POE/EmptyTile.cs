using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    [Serializable]
    class EmptyTile : Tile
    {
        public EmptyTile(int _posx, int _posy, string _symbol = " ") : base(_posx, _posy, _symbol)
        {

        }
    }
}
