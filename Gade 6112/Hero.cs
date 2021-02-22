using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    [Serializable]
    public class Hero : Character
    {

        
        public Hero (int X, int Y, int hp, int damage = 2, string Symbol = "H") : base (X, Y, Symbol)
        {
            HP = hp; 
            MaxHP = hp;
            Damage = damage;
        }

        

        public override string ToString()
        {
            string infoDisplay = "";
            
            infoDisplay += HP;
            infoDisplay += X + Y;
            infoDisplay += Damage;
            return infoDisplay;
        }


        public override MovementEnum ReturnMove(MovementEnum move)
        {
            if (move == MovementEnum.Up)
            {
                move = MovementEnum.Up;
                X--;
            }

            else if (move == MovementEnum.Down)
            {
                move = MovementEnum.Down;
                X++;
            }

            else if (move == MovementEnum.Right)
            {
                move = MovementEnum.Right;
                y++;
            }

            else if (move == MovementEnum.Left)
            {
                move = MovementEnum.Left;
                Y--;
            }

            else if (move == MovementEnum.No_Movement)
            {
                move = MovementEnum.No_Movement;

               
            }

            return move;
        }

        
    }
}
