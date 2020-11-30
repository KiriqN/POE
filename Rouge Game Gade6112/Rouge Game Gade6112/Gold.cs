using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Game_Gade6112
{
    class Gold : item
    {
        private Random rand = new Random();

        private int GoldQuantity;
        public Gold(int x, int y, char Symbol) : base (x, y, 'I')
        {
            GoldQuantity = rand.Next(1, 5);
        }

        public int goldquantity
        {
            get { return GoldQuantity;  }
            set { goldquantity = value;  }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
