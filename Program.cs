using System;
using static System.Net.Mime.MediaTypeNames;

namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] input = { 1, 0, 0, 0, 0, 1 };
            int n = 2;
            Console.WriteLine(CanPlantFlowers(input, n));

            //2
            Console.WriteLine(WaysToClimb(5));

           

        }

        public static bool CanPlantFlowers(int[] input, int n)
        {
            //can plant if left neighbor AND right neighbor is empty
            //arr[i-1] and arr[i + 1] == 0, arr[i] = 1
            //account for first index and last index if 0
            //loop for when i == 0,
            //if i = 1, skip to next index.
            //decrement n if left and right == 0
            //return true when n = 0

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 1) continue;
                // left empty and right empty
                // if first index assume left empty, if last index assume right empty
                if (( i == 0 || input[i-1] == 0 ) && (i == input.Length - 1 || input[i+1] == 0))
                {
                    input[i] = 1;
                    n--;
                }
                
            }
            return n <= 0;
        }

        //2
        static int count = 0;
        public static int WaysToClimb(int totalSteps)
        {
            //base cases
            //1 step from total = n - 1
            //2 steps from total = n - 2
            if (totalSteps < 0)
            {
                return 0;
            }
            if (totalSteps == 0)
            {
                return 1;
            }
            if (totalSteps == 1)
            {
                return 1;
            }
            return WaysToClimb(totalSteps - 1) + WaysToClimb(totalSteps - 2);

        }

      
    }
}
