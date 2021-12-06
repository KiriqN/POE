using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_6112
{
    class Leader : Enemy
    {
        private Tile leadertarget;

        public Tile Leadertarget
        {
            get { return leadertarget; }
            set { leadertarget = value; }
        }

        public Leader(int X, int Y, Hero target, string Symbol = "L") : base(X, Y, 2, 20, 20, Symbol)
        {
            leadertarget = target;
            base.purse = 2;
            base.weaponItem = new MeleeWeapon(MeleeWeapon.Mtypes.Longsword, X, Y, "7");
        }


        public override MovementEnum ReturnMove(MovementEnum newmovementEnum = 0)
        {
            MovementEnum leadermovement = FollowPlayer(newmovementEnum);
            if (leadermovement == MovementEnum.No_Movement)
            {
                RandomMove(leadermovement);
            }

            return newmovementEnum;
        }

        public MovementEnum FollowPlayer(MovementEnum newmovementEnum = 0)
        {
            int leaderpositionX;
            int leaderpositionY;
            leaderpositionX = X - leadertarget.X;
            leaderpositionY = Y - leadertarget.Y;
            newmovementEnum = MovementEnum.No_Movement;


            if (Math.Abs(leaderpositionX) >= Math.Abs(leaderpositionY))
            {
                if (leaderpositionX < 0 && vision[2] is EmptyTile || vision[2] is Item && !(vision[2] is Hero))
                {
                    
                    newmovementEnum = MovementEnum.Right;
                    base.X++;

                }

                if (leaderpositionX > 0 && vision[0] is EmptyTile || vision[0] is Item && !(vision[0] is Hero))
                {
                    
                    newmovementEnum = MovementEnum.Left;
                    base.X--;
                }
                if (Math.Abs(leaderpositionY) > Math.Abs(leaderpositionX))
                {
                    if (leaderpositionY < 0 && vision[1] is EmptyTile || vision[1] is Item && !(vision[1] is Hero))
                    {
                        
                        newmovementEnum = MovementEnum.Up;
                        base.Y++;
                    }
                    if (leaderpositionX > 0 && vision[3] is EmptyTile || vision[3] is Item && !(vision[3] is Hero))
                    {
                        
                        newmovementEnum = MovementEnum.Down;
                        base.Y--;
                    }


                }
            }
            return newmovementEnum;     
        }


        public MovementEnum RandomMove(MovementEnum newMovementenum = 0)
        {
            int leaderdirection = enemymove.Next(0, 4);
            newMovementenum = MovementEnum.No_Movement;

            while (newMovementenum == MovementEnum.No_Movement)
            {
                if (leaderdirection == 0)
                {
                    if (vision[0] is EmptyTile || vision[0] is Item && !(vision[0] is Hero))
                    {
                        
                        newMovementenum = MovementEnum.Left;
                        X--;
                    }
                    else
                    {
                        leaderdirection = enemymove.Next(0, 4);
                    }

                }
                else if (leaderdirection == 1)
                {
                    if (vision[1] is EmptyTile || vision[1] is Item && !(vision[1] is Hero))
                    {
                        
                        newMovementenum = MovementEnum.Up;
                        Y--;
                    }
                    else
                    {
                        leaderdirection = enemymove.Next(0, 4);
                    }
                }
                else if (leaderdirection == 2)
                {
                    if (vision[2] is EmptyTile || vision[2] is Item && !(vision[2] is Hero))
                    {
                       
                        newMovementenum = MovementEnum.Right;
                        X++;
                    }
                    else
                    {
                        leaderdirection = enemymove.Next(0, 4);
                    }
                }
                else if (leaderdirection == 3)
                {
                    if (vision[3] is EmptyTile || vision[3] is Item && !(vision[3] is Hero))
                    {
                        
                        newMovementenum = MovementEnum.Down;
                        Y++;
                    }
                    else
                    {
                        leaderdirection = enemymove.Next(0, 4);
                    }
                }
                else
                {
                    newMovementenum = MovementEnum.No_Movement;
                }
                
            }
            return newMovementenum;


        }


    }
}
