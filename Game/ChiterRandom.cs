using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ChiterRandom : Players
    {
        public ChiterRandom(string name) : base(name) { }

        public override void Action()
        {
            while (true)
            {
                lock (Game.locker)
                {
                    if (!Game.win)
                    {
                        int tryRandom = Game.Random.Next(Game.SmallestNumber, Game.BiggestNumber);

                        if (Game.ArrField[tryRandom] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            if (Game.ArrField[tryRandom] != 2)
                            {
                                Console.WriteLine($"{Name} think is number {tryRandom}, and this number WRONG!!!");
                                Game.ArrField[tryRandom] = 1;

                            }
                            else
                            {
                                Console.WriteLine($"{Name} think is number {tryRandom}, {Name} Win!");
                                Game.win = true;
                                break;
                            }
                        }
                    }

                    else break;
                }
            }
        }
    }
}