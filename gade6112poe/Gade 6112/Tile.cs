using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
    public abstract class Tile
    {
        protected int x;
        protected int y;
        protected string symbol;
        protected TileType type;


        public TileType Type
        {
            get { return type; }
            set { type = value; }
        }
        public enum TileType
        {
            Gold,
            Enemy,
            Hero,
            Weapon,
            Item
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

       
        public int Y
        {
           get { return y; }
           set { y = value; }
        }


        public string Symbol
        {
            get { return symbol; }
        }
        
           
        



        public Tile(int X, int Y, string Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;

        }
    }
}
