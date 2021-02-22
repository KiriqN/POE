using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using static Gade_6112.Character;





namespace Gade_6112
{

    public enum TileType
    {
        Gold,
        Enemy,
        Hero,
        Weapon,
        Item
    }

    class GameEngine
    {
        


        private Map maptiles = new Map(20, 20, 20, 20, 5, 3);

        public Map MapTiles
        {
            get { return maptiles; }
            set { maptiles = value; }
        }

        public override string ToString()
        {
            string field = "";

            for (int j = 0; j < MapTiles.MapWidth; j++)
            {
                for (int i = 0; i < MapTiles.MapHeight; i++)
                {
                    field += MapTiles.maptiles[j, i].Symbol + " ";
                }


                field += "\t";

            }
            return field;
        }

        public bool MovePlayer(MovementEnum move)
        {
            MovementEnum PlayerMove = MapTiles.Hero.ReturnMove(move);
            MapTiles.Hero.Move(PlayerMove);

            MapTiles.UpdateMap();

            if (PlayerMove == MovementEnum.No_Movement)
            {
                
                return true;
            }

            return false;

        }

        public void saveGame()
        
        
        {
            FileStream file = new FileStream("file has been saved", FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(file, MapTiles);

            file.Close();
            MessageBox.Show("Save Successful");
        }

        public void loadGame()
        {
            FileStream file = new FileStream("file loaded", FileMode.Open, FileAccess.Read);
            BinaryFormatter format = new BinaryFormatter();
            Map load = (Map)format.Deserialize(file);

            file.Close();

            maptiles.UpdateMap();
            MessageBox.Show("Map loaded");

            
        }


    }
}

