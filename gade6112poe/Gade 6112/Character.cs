using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gade_6112.GameEngine;

namespace Gade_6112
{
    [Serializable]
     abstract class Character : Tile
    {   
        protected Weapon weaponItem;
        protected int hp;
        protected int maxhp;
        protected int damage;
        protected Tile[] vision = new Tile[4];
        protected MovementEnum move;
        protected int purse;
        protected Random rnd;
        

        public enum MovementEnum
        {
            No_Movement,
            Up,
            Down,
            Left,
            Right

        }

        public Weapon WeaponItem
        {
            get { return weaponItem; }
            set { weaponItem = value; }
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

        public Tile[] Vision
        {
            get { return vision; }
            set { vision = value; }
        }

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

            if (this is Goblin)
            {
                MeleeWeapon goblin = new MeleeWeapon(MeleeWeapon.Mtypes.Dagger, 1, 1, "D");
                Equip(goblin);
            }

            else if (this is Leader)
            {
                MeleeWeapon leader = new MeleeWeapon(MeleeWeapon.Mtypes.Longsword, 1, 1, "7");
                Equip(leader);
            }

            else if (this is Hero)
            {
                MeleeWeapon hero = new MeleeWeapon(MeleeWeapon.Mtypes.Bare_Hands, 1, 1, "0");
                Equip(hero);
            }
        }

        private void Equip(Weapon w)
        {
            weaponItem = w;
            this.damage = w.Damage;
        }

        public virtual void Attack(Character target)
        {
            target.HP -= Damage;
            if (target.HP <= 0)
            {
                Loot(target);
            }
        }

        public bool IsDead ()
        {
            if (HP <= 0)
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

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(MovementEnum move)
        {
             if (move == MovementEnum.Up)
            {
                X--;
            }

             else if (move == MovementEnum.Down)
            {
                X++;
            }

            else if (move == MovementEnum.Right)
            {
                Y++;
            }

            else if (move == MovementEnum.Left)
            {
                Y--;
            }

            else
            {
                // idle state
            }
        }

        public virtual void Loot(Character target)
        {
            purse += target.purse;

        }

        public void Pickup(Item item)
        {
            if (item.GetType() == typeof(Gold))
            {
                rnd = new Random();
                purse += rnd.Next(1, 3);
            }
            else if (item.GetType().BaseType == typeof(Weapon))
            {
                PickupWeapon(item as Weapon);
            }
            

        }

        public void PickupWeapon(Weapon WeaponPickUp)
        {
            weaponItem = WeaponPickUp;
        }

       
        public abstract MovementEnum ReturnMove(MovementEnum move = 0);


        public abstract override string ToString();


    }
}
