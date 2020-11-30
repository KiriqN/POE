using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Game_Gade6112
{
  public abstract class item : Tile
    {
        public item(int x, int y, char Symbol) : base ( x, y, 'I')
        {

        }

        public abstract string ToString();
    }
}
