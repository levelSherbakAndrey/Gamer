using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public  class PlayerSimply : Players
    {
        int Count = Game.SmallestNumber;

        public PlayerSimply(string name) : base(name){ }


       


        public override void Action()
        {
            lock (Game.locker)
            {
                if (!Game.win)
                {
                    for (int i = Game.SmallestNumber; i < Game.ArrField.Length; i++)
                    {
                        if (Game.ArrField[i] == 2)
                        {
                            Console.WriteLine($"{Name} think is number {i}, {Name} Win!");
                            Game.win = true;
                            break;
                        }
                        else
                        {
                            Game.ArrField[i] = 1;
                            Console.WriteLine($"{Name} think is number {i}, and this number WRONG!!!");
                        }
                    }
                }
            }
        }
    }
}
