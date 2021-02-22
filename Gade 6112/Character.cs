using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    [Serializable]
    public abstract class Character : Tile
    {
        protected int hp;
        protected int maxhp;
        protected int damage;
        protected Tile[] vision;
        protected MovementEnum move;
        protected int purse;

        public enum MovementEnum
        {
            No_Movement,
            Up,
            Down,
            Left,
            Right

        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int MaxHP
        { 
          get { return maxhp; }
          set { maxhp = value; }
        }


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Tile[] Vision { get; set; }

        public MovementEnum MOVE
        {
            get { return move; }
            set { move = value; }
        }

        public int Purse
        {
            get { return purse; }
            set { purse = value; } 
        }


        public Character (int X, int Y, string Symbol) : base (X, Y , Symbol)
        {
            this.vision = new Tile[4];
        }

        public virtual void Attack(Character Target)
        {
            Target.HP -= this.Damage;
        }

        public bool IsDead ()
        {
            if (HP <=0)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange (Character Target)
        {
            if (DistanceTo(Target) <=1 && DistanceTo(Target) >=-1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int DistanceTo(Character Target)
        {
            return Math.Abs(Target.X - this.X) + Math.Abs(Target.Y - this.Y);
        }

        public void Move(MovementEnum move)
        {
            if (move == MovementEnum.Up)
            {
                Y++;
            }

            if (move == MovementEnum.Down)
            {
                Y--;
            }

            if (move == MovementEnum.Right)
            {
                X++;
            }

            if (move == MovementEnum.Left)
            {
                X--;
            }
        }

        public void Pickup(Item i)
        {
            if (i == null)
            {
                return;
            }
            else if (i.Type == TileType.Gold)
            {
                purse++;
                return;
            }
            else if (i.Type == TileType.Weapon)
            {
                
            }

        }
        public abstract MovementEnum ReturnMove(MovementEnum move = 0);


        public abstract override string ToString();


    }
}
