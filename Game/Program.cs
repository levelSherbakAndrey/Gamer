using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        { 
            Game.AddGame(out Game.ArrField);
  
            PlayerSimply player1 = new PlayerSimply("Bob");
            PlayerRandomSimply player2 = new PlayerRandomSimply("John");
            PlayerRandomHard player3 = new PlayerRandomHard("Bill");
            ChiterSimply player4 = new ChiterSimply("Benjamine");
            ChiterRandom player5 = new ChiterRandom("Violetta");

            Thread a = new Thread(player1.Action);
            a.Start();
            Thread b = new Thread(player2.Action);
            b.Start();
            Thread c = new Thread(player3.Action);
            c.Start();
            Thread d = new Thread(player4.Action);
            d.Start();
            Thread e = new Thread(player5.Action);
            e.Start();





            //while (true)
            //{
            //    Console.WriteLine();
            //    if (!player1.Action())
            //    {
            //        break;
            //    }
            //    if (!player2.Action())
            //    {
            //        break;
            //    }
            //    else if (!player3.Action())
            //    {
            //        break;
            //    }
            //    else if (!player4.Action())
            //    {
            //        break;
            //    }
            //    else if (!player5.Action())
            //    {
            //        break;
            //    }
            //}
        }


    }
}
