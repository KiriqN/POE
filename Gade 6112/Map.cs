using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.Tile;

namespace Gade_6112
{
    [Serializable]
    class Map
    {
        public Tile[,] maptiles;

        private Hero hero;

        public Enemy[] enemies;

        public Item [] item;

        private Random rnd = new Random();

        public Tile[,] MapTiles {get; set;}

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public Enemy[] Enemies { get; set; }

        public int MapHeight { get; set; }

        public int MapWidth { get; set; }

        public Item[] Item { get; set; }

        public Map(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int Enemies, int Item )
        {
            MapWidth = rnd.Next(MinWidth, MaxWidth);
            MapHeight = rnd.Next(MinHeight, MaxHeight);

            maptiles = new Tile[MapWidth, MapHeight];
            enemies = new Enemy[Enemies];
            item = new Item[Item];
            

            
            FillMap();
            InitializeMap();

            Hero = (Hero)Create(type : TileType.Hero);
            maptiles[Hero.X, Hero.Y] = Hero;

            for (int j = 0; j < enemies.Length; j++)
            {
                enemies[j] = (Enemy)Create(type : TileType.Enemy);
                maptiles[enemies[j].X, enemies[j].Y] = enemies[j];
            }
            for (int j = 0; j < item.Length; j++)
            {
                item[j] = (Item)Create(TileType.Gold);
                maptiles[item[j].X, item[j].Y] = item[j];
            }


            
        }
        
        private Tile Create(TileType type)
        {
            int X = rnd.Next(0, MapWidth);
            int Y = rnd.Next(0, MapHeight);

            while (maptiles[X, Y] is Obstacle || maptiles[X, Y] is Character || maptiles[X, Y] is Item)
            {
                X = rnd.Next(0, MapWidth);
                Y = rnd.Next(0, MapHeight);
            }
            if (type == TileType.Hero)
            {
                Hero = new Hero(X, Y, 100, 2, "H");
                return Hero;
            }
            else if (type == TileType.Enemy)
            {
                int random = rnd.Next(1, 4);
                if (random == 1)
                {
                    return new Goblin(X, Y);
                }
                else if (random == 2)
                {
                    return new Mage(X, Y);
                }
                else
                {
                    return new Leader(X, Y);
                }
            }
            else 
            {
                return new Gold(X, Y);
            }

            





        }
        public void UpdateVision()
        {
            Hero.Vision[0] = maptiles[Hero.X - 1, Hero.Y];
            Hero.Vision[1] = maptiles[Hero.X, Hero.Y - 1];
            Hero.Vision[2] = maptiles[Hero.X + 1, Hero.Y];
            Hero.Vision[3] = maptiles[Hero.X, Hero.Y + 1];

            foreach (Enemy enemy in enemies)
            {
                enemy.Vision[0] = maptiles[enemy.X - 1, enemy.Y];
                enemy.Vision[1] = maptiles[enemy.X, enemy.Y - 1];
                enemy.Vision[3] = maptiles[enemy.X, enemy.Y + 1];
                enemy.Vision[2] = maptiles[enemy.X + 1, enemy.Y];
            }
        }
        private void InitializeMap()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                for (int x = 0; x < MapWidth; x++)
                {
                   try
                    {
                        maptiles[x, y] = new EmptyTile(x, y, ".");
                    }
                    catch (OverflowException)
                    {
                        
                    }
                }
            }
        }
        public void UpdateMap()
        {
            InitializeMap();
            maptiles[Hero.X, Hero.Y] = Hero;

            foreach (Enemy enemy in enemies)
            {
                if (enemy.IsDead() == false)
                {
                    maptiles[enemy.X, enemy.Y] = enemy;
                }
            }
            foreach (Item gold in item)
            {
                if (gold != null)
                {
                    maptiles[gold.X, gold.Y] = gold;
                }
            }
            UpdateMap();
        }
       
        public void FillMap()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    maptiles[x, y] = new EmptyTile(x, y, "."); 
                }
            }
        }
        

    }
} 

