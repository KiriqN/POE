using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gade_6112.Character;



namespace Gade_6112
{
    public partial class Form1 : Form
    {
        
        
        List<Enemy> enemies = new List<Enemy>();
        GameEngine gameengine;
        Shop buyer;

        public Form1()
        {
            InitializeComponent();
            gameengine = new GameEngine();
            
            DisplayMap();
            



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void DisplayMap()
        {
            
            field.Text = gameengine.ToString();
            PlayerStats.Text = "";
            PlayerStats.Text = gameengine.MapTiles.Hero.ToString();
            EnemyBox.Items.Clear();
            EnemyBox.Items.Remove(EnemyBox.SelectedItem);
            
            ShopBox.Text = gameengine.MapTiles.shop.DisplayWeapon(0);
            ShopBox.Text = gameengine.MapTiles.shop.DisplayWeapon(1);
            ShopBox.Text = gameengine.MapTiles.shop.DisplayWeapon(2);

            
            

            foreach (Enemy EnemyInRange in gameengine.MapTiles.enemies)
            {
                if (gameengine.MapTiles.Hero.CheckRange(EnemyInRange) && EnemyInRange.IsDead() == false)
                {
                    enemies.Add(EnemyInRange);
                    EnemyBox.Items.Add(EnemyInRange.ToString());

                }

            } 


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void field_Click(object sender, EventArgs e)
        {
            field.Text = "";
            field.Text = gameengine.ToString();
        }


        public void GameUpdate()
        {
            field.Text = "";
            field.Text = gameengine.ToString();
            PlayerStats.Text = gameengine.MapTiles.Hero.ToString();
            EnemyBox.Items.Clear();
            EnemyBox.Items.Remove(EnemyBox.SelectedItem);
            DisplayHeroStats();

            if (EnemyBox.SelectedItem != null)
            {
                EnemyStats.Text = EnemyBox.SelectedItem.ToString();
                GameUpdate();
            }
           
            gameengine.EnemyMove();
            


            foreach (Enemy EnemyInRange in gameengine.MapTiles.enemies)
            {
                if (gameengine.MapTiles.Hero.CheckRange(EnemyInRange) && EnemyInRange.IsDead() == false)
                {
                    enemies.Add(EnemyInRange);
                    EnemyBox.Items.Add(EnemyInRange.ToString());
                }

            }


        }



        public void DisplayHeroStats()
        {
            PlayerStats.Text = "";
            PlayerStats.Text = gameengine.MapTiles.Hero.ToString();
            
        }
        private void PlayerBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            gameengine.saveGame();
        }

        private void load_Click(object sender, EventArgs e)
        {
            gameengine.loadGame();
            enemies = new List<Enemy>();
            field.Text = "";
            field.Text = gameengine.ToString();

        }

        public void MoveRight()
        {
            
            gameengine.MovePlayer(MovementEnum.Right);
            GameUpdate();
        }

        public void MoveLeft()
        {
            gameengine.MovePlayer(MovementEnum.Left);
            GameUpdate();
        }

        public void MoveDown()
        {
            gameengine.MovePlayer(MovementEnum.Down);
            GameUpdate();
        }

        public void MoveUp()
        {
            gameengine.MovePlayer(MovementEnum.Up);
            GameUpdate();
        }

        private void right_Click(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            MoveUp();
            GameUpdate();
        }

        private void left_Click(object sender, EventArgs e)
        {
            MoveLeft();
            GameUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveDown();
            GameUpdate();
        }

        private void PlayerStats_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EnemyStats_Click(object sender, EventArgs e)
        {
            
        }

        public void DisplayEnemyStats()
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attack_Click(object sender, EventArgs e)
        {
            if (EnemyBox.SelectedText != " ")
            {

                //Debug.WriteLine("Selected index:  " + EnemyBox.SelectedIndex);
                //Debug.WriteLine("Collection size:  " + enemies.Count);
                gameengine.MapTiles.Hero.Attack(enemies[EnemyBox.SelectedIndex]);
                EnemyStats.Text = enemies[EnemyBox.SelectedIndex].ToString();
                gameengine.EnemyAttack();
                field.Text = "";
                field.Text = gameengine.ToString();
                DisplayHeroStats();
                DisplayEnemyStats();
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GameInfo.Text = " ";
            if (gameengine.shop.CanBuy(0) == false)
            {
                GameInfo.Text += " you do not have enough gold to purchase this item \n";
            }

            else if (gameengine.shop.CanBuy(0) == true)
            {
                gameengine.shop.Buy(0);
                GameInfo.Text += " You have bought the" + gameengine.MapTiles.shop.BoughtWeapon1(0);
                DisplayHeroStats();

            }
        }

        private void Buy2_Click(object sender, EventArgs e)
        {
            GameInfo.Text = " ";
            if (gameengine.shop.CanBuy(1) == false)
            {
                GameInfo.Text += " you do not have enough gold to purchase this item \n";
            }

            else if (gameengine.shop.CanBuy(1) == true)
            {
                gameengine.shop.Buy(1);
                GameInfo.Text += " You have bought the" + gameengine.MapTiles.shop.BoughtWeapon2(1);
                DisplayHeroStats();

            }
        }

        private void Buy3_Click(object sender, EventArgs e)
        {
            GameInfo.Text = " ";
            if (gameengine.shop.CanBuy(2) == false)
            {
                GameInfo.Text += " you do not have enough gold to purchase this item \n";
            }

            else if (gameengine.shop.CanBuy(2) == true)
            {
                gameengine.shop.Buy(2);
                GameInfo.Text += " You have bought the" + gameengine.MapTiles.shop.BoughtWeapon3(2);
                DisplayHeroStats();

            }
        }
    }
    }

