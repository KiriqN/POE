using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.Tile;
using static Gade_6112.Character;

namespace Gade_6112
{
    [Serializable]
    class Map
    {
        public Tile[,] maptiles;

        private Hero hero;

        public Enemy[] enemies;

        public Item[] item;

        private int mapheight;

        private int mapwidth;

        public Shop shop;

        private Random rnd = new Random();

        public Tile[,] MapTiles { get; set; }

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public Enemy[] Enemies { get; set; }

        public int MapHeight
        {
            get { return mapheight; }
            set { mapheight = value; }

        }

        public int MapWidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        public Item[] Item { get; set; }

        public Map(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int Enemies, int Item)
        {
            MapWidth = rnd.Next(MinWidth, MaxWidth);
            MapHeight = rnd.Next(MinHeight, MaxHeight);

            maptiles = new Tile[MapWidth, MapHeight];
            enemies = new Enemy[Enemies];
            item = new Item[Item];

            shop = new Shop(Hero);

            FillMap();
            InitializeMap();

            Hero = (Hero)Create(type: TileType.Hero);
            maptiles[Hero.X, Hero.Y] = Hero;

            for (int j = 0; j < enemies.Length; j++)
            {
                enemies[j] = (Enemy)Create(type: TileType.Enemy);
                maptiles[enemies[j].X, enemies[j].Y] = enemies[j];
            }
            for (int i = 0; i < item.Length; i++)
            {
                int itemlocations = rnd.Next(1, 3);
                if (itemlocations == 1)
                {
                    item[i] = (Item)Create(TileType.Gold);
                }
                if (itemlocations == 2)
                {
                    item[i] = (Item)Create(TileType.Weapon);
                }

                maptiles[item[i].X, item[i].Y] = item[i];
            }

            UpdateVision();
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
                    return new Leader(X, Y, Hero);
                }
            }

            else if (type == TileType.Weapon)
            {
                int weaponlocations = rnd.Next(1, 5);

                if (weaponlocations == 1)
                {
                    return new RangedWeapon(RangedWeapon.Rtypes.LongBow, X, Y, "7");
                }
                else if (weaponlocations == 2)
                {
                    return new RangedWeapon(RangedWeapon.Rtypes.Rifle, X, Y, "R");
                }
                else if (weaponlocations == 3)
                {
                    return new MeleeWeapon(MeleeWeapon.Mtypes.Dagger, X, Y, "D");
                }
                else if (weaponlocations == 4)
                {
                    return new MeleeWeapon(MeleeWeapon.Mtypes.Longsword, X, Y, "1");
                }

                else
                {
                    return new MeleeWeapon(MeleeWeapon.Mtypes.Bare_Hands, X, Y, "B");
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
            
            GetItemAtPosition(Hero); 

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

        public void InitializeMap()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    maptiles[x, y] = new EmptyTile(x, y, ".");
                }
            }
            Obstacles();

        }

        public void Obstacles()
        {
            for (int x = 0; x < mapwidth; x++)
            {
                for (int y = 0; y < mapheight; y++)
                {
                    if (x == 0 || y == 0 || x == mapwidth - 1 || y == mapheight - 1)
                    {
                        maptiles[x, y] = new Obstacle(x, y, "X");
                    }
                }
            }


        }


        public void GetItemAtPosition(Character character)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i].X == character.X && item[i].Y == character.Y) // if same position as item
                {
                    if (item[i].GetType() == typeof(Gold))
                    {
                        character.Pickup((Gold)item[i]); // Pick up

                        item = item.Where((source, index) => index != i).ToArray(); // remove from itemArray
                    }

                     //make sure to call Equip in here
                    
                    if (item[i].GetType().BaseType == typeof(Weapon))
                    {
                        character.Pickup((Weapon)item[i]);

                        item = item.Where((source, index) => index != i).ToArray();
                    }




                }





            }
        }
    }
}




