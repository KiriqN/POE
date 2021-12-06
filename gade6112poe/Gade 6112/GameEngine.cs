using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using static Gade_6112.Character;
using static Gade_6112.Map;
using static Gade_6112.Hero;





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

    public enum WeaponTypes
    {
        LongBow,
        Rifle,
        Dagger,
        Longsword,
        Bare_Hands
    }

    class GameEngine
    {
        public Shop shop;


        private Map maptiles = new Map(11, 11, 12, 12, 3, 3);
        
        public GameEngine()
        {
            shop = new Shop(maptiles.Hero);
        }

        public Map MapTiles
        {
            get { return maptiles; }
            set { maptiles = value; }
        }

        public override string ToString()
        {
            string field =  string.Empty;

            for (int j = 0; j < MapTiles.MapWidth; j++)
            {
                for (int i = 0; i < MapTiles.MapHeight; i++)
                {
                    field += MapTiles.maptiles[j, i].Symbol + " ";
                }


                field += "\n";

            }
            return field;
        }

       

        public bool MovePlayer(MovementEnum move)
        {
            MovementEnum PlayerMove = MapTiles.Hero.ReturnMove(move);
            //MapTiles.Hero.Move(PlayerMove);

            MapTiles.UpdateMap();

            if (PlayerMove == MovementEnum.No_Movement)
            {

                return false;
            }
            else
            {
                
            }

            return true;

        }

        public void saveGame()


        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream file = new FileStream("file.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (file)
                {
                    format.Serialize(file, maptiles);
                }
                MessageBox.Show("Game Saved");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void loadGame()
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream file = new FileStream("file.bin", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                
                maptiles.UpdateMap();
                MessageBox.Show("Game Loaded");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }

        public void EnemyMove()
        {
            MovementEnum HeroMovement;
            maptiles.UpdateVision();
            foreach (Enemy enemyselect in maptiles.enemies)
            {
                maptiles.UpdateVision();
                HeroMovement = enemyselect.ReturnMove();
                if (enemyselect is Goblin)
                {
                    if (enemyselect.CheckRange(maptiles.Hero))
                    {
                        enemyselect.Attack(maptiles.Hero);
                    }
                }
                else if (enemyselect is Leader)
                {
                    if (enemyselect.CheckRange(maptiles.Hero))
                    {
                        enemyselect.Attack(maptiles.Hero);
                    }
                }
                else if (enemyselect is Mage)
                {
                    if (enemyselect.CheckRange(maptiles.Hero))
                    {
                        enemyselect.Attack(maptiles.Hero);
                    }
                    for (int i = 0; i < maptiles.enemies.Length; i++)
                    {
                        if (maptiles.enemies[i].X != enemyselect.X && maptiles.enemies[i].Y != enemyselect.Y)
                        {
                            if (enemyselect.CheckRange(maptiles.enemies[i]))
                            {
                                enemyselect.Attack(maptiles.enemies[i]);
                            }
                        }
                        maptiles.UpdateMap();
                    }
                }
            }
        }

        public void EnemyAttack()
        {
            maptiles.UpdateMap();
            foreach (Enemy enemytarget in maptiles.enemies)
            {
                if (enemytarget is Goblin)
                {
                    if (enemytarget.CheckRange(maptiles.Hero))
                    {
                        enemytarget.Attack(maptiles.Hero);
                    }
                            
                }

                else if (enemytarget is Mage)
                {
                    if (enemytarget.CheckRange(maptiles.Hero))
                    {
                        enemytarget.Attack(maptiles.Hero);
                    }
                    for (int j = 0; j < MapTiles.enemies.Length; j++)
                    {
                        if(maptiles.enemies[j].X != enemytarget.X && maptiles.enemies[j].Y != enemytarget.Y)
                        {
                            if (enemytarget.CheckRange(maptiles.enemies[j]))
                            {
                                enemytarget.Attack(maptiles.enemies[j]);
                            }
                        }
                    }
                }
            }
        }
        


    }
}


    


