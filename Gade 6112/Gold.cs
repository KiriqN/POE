using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    [Serializable]
    class Gold : Item
    {
        private Random rnd = new Random();

        private int goldamount;

        
        public int GoldAmount { get; set; }

        public Gold(int X, int Y, string Symbol = "g") : base (X, Y, Symbol)
        {
            goldamount = rnd.Next(0, 5);
        }

        public override string ToString()
        {
            return "g";
        }
    }

    }

