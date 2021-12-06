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
     class Hero : Character
    {

        
        public Hero (int X, int Y, int hp, int damage = 2, string Symbol = "H") : base (X, Y, Symbol)
        {
            HP = hp; 
            MaxHP = hp;
            Damage = damage;
            purse = 10;
            base.weaponItem = new MeleeWeapon(MeleeWeapon.Mtypes.Bare_Hands, X, Y, "B");
        }

        

        public override string ToString()
        {
            return $"Player Stats:\nHP: {this.hp}/{this.MaxHP} \n" +
                   $"Damage: {this.damage} \n" +
                   $"[{this.x}, {this.y}], \n " +
                   $"Gold:{this.purse} \n " +
                   $"Current Weapon: {weaponItem.WeaponName} \n " +
                   $"Weapon Range: {weaponItem.Range} \n " +
                   $"Weapon Damage: {weaponItem.Damage}" ;
        }


        public override MovementEnum ReturnMove(MovementEnum move)
        {
            if (move == MovementEnum.Up)
            {
                if (vision[0] is EmptyTile || vision[0] is Item)
                {
                    move = MovementEnum.Up;
                    x--;
                }
            }

            else if (move == MovementEnum.Down)
            {
                if (vision[1] is EmptyTile || vision[1] is Item)
                {
                    move = MovementEnum.Down;
                    x++;
                }
            }

            else if (move == MovementEnum.Right)
            {
                if (vision[2] is EmptyTile || vision[2] is Item)
                {

                    move = MovementEnum.Right;
                    y++;
                }
            }

            else if (move == MovementEnum.Left)
            {
                if (vision[3] is EmptyTile || vision[3] is Item)
                {
                    move = MovementEnum.Left;
                    y--;
                }
            }

            else if (move == MovementEnum.No_Movement)
            {
                move = MovementEnum.No_Movement;

               
            }

            return move;
        }

        
    }
}
