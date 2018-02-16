using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ChiterSimply : Players
    {
        public ChiterSimply(string name) : base(name) { }
        int Count = Game.SmallestNumber;

        public override void Action()
        {
            while (true)
            {
               
                    if (!Game.win)
                    {
                        if (Game.ArrField[Count] == 1)
                        {
                            Count++;
                        }
                        else
                        {
                            if (Game.ArrField[Count] != 2)
                            {
                                Console.WriteLine($"{Name} think is number {Count}, and this number WRONG!!!");
                                Game.ArrField[Count] = 1;
                                if (Count != Game.BiggestNumber)
                                    Count++;

                            }
                            else
                            {
                                Console.WriteLine($"{Name} think is number {Count}, {Name} Win!");
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
