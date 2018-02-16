using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class Game
    {
        private static int _smallestNumber;
        private static int _biggestNumber;
        public static bool win;
        public static object locker = new object(); 

        public static int SmallestNumber { get { return _smallestNumber; } }
        public static int BiggestNumber { get { return _biggestNumber; } }

        public static int[] ArrField;

        public static Random Random = new Random();




        private static void AddSmallestNumber()
        {
            bool Enter = true;
            while (Enter)
            {
                Console.WriteLine("Enter Smallest number: ");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                {
                    _smallestNumber = result;
                    Enter = false;
                }
                else
                {
                    Console.WriteLine("You write wrong number, try again: ");
                }
            }
        }


        private static void AddBiggestNumber()
        {
            bool Enter = true;
            while (Enter)
            {
                Console.WriteLine("Enter Biggest number: ");
                if(int.TryParse(Console.ReadLine(), out int result) && result > _smallestNumber)
                {
                    _biggestNumber = result;
                    Enter = false;
                }
                else
                {
                    Console.WriteLine("You write wrong number, try again");
                }
            }
        }


        public static void AddGame( out int[] arr)
        {
            AddSmallestNumber();
            AddBiggestNumber();

            arr = new int[_biggestNumber + 1];
          
            int rnd = Random.Next(_smallestNumber, _biggestNumber);
            Console.WriteLine(rnd);

            for (int i = _smallestNumber; i < arr.Length; i++)
            {
                if (i == rnd)
                {
                    arr[i] = 2;
                }
                else
                {
                    arr[i] = 0;
                }
            }
        }

    }
}
