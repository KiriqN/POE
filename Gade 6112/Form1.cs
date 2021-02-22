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
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    public partial class Form1 : Form
    {
        
        GameEngine gameengine;
        List<Enemy> enemies = new List<Enemy>();

        public Form1()
        {
            InitializeComponent();
            DisplayHeroStats();
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
            DisplayHeroStats();
        }



        public void DisplayHeroStats()
        {
            
            {
                PlayerStats.Text = "HP / MaxHP \n " + 
                    "[X, Y] \n" +
                     "Damage \n";
               // PlayerStats.Text = gameengine.MapTiles.Hero.ToString();
            }
            
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
        }

        private void left_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void PlayerStats_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EnemyStats_Click(object sender, EventArgs e)
        {
            DisplayEnemyStats();
        }

        public void DisplayEnemyStats()
        {
            {
                EnemyStats.Text = "HP / MaxHP \n " +
                        "[X, Y] \n" +
                         "Damage \n";
            }
        }
    }
}
