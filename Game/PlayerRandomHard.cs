using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class PlayerRandomHard : Players
    {
        private int[] arrPlayer = new int[Game.BiggestNumber + 1];

        public PlayerRandomHard(string name) : base(name) { }



        public override void Action()
        {
            while (true)
            {
                lock (Game.locker)
                {
                    if (!Game.win)
                    {
                        int tryRandom = Game.Random.Next(Game.SmallestNumber, Game.BiggestNumber);

                        if (arrPlayer[tryRandom] != 1)
                        {
                            arrPlayer[tryRandom] = 1;

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
