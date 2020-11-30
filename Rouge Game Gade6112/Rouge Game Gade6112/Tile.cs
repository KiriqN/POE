using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Game_Gade6112
{
    abstract class Tile
    {
        public int X
        {
            get { return X; }
            set { X = value; }
        }

        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }

        public int SYMBOL
        {
            get { return SYMBOL;  }
        }
        
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }



        protected Tile(int x, int y, char Symbol)
        {
            Y = y;
            X = x;
            
        }

        public TileType tiletype
        {
            get { return tiletype; }
            set { tiletype = value; }
        }

        






    }

    

}
