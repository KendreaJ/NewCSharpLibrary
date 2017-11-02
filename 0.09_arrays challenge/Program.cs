using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_arrays_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
        

            //Gold Challenge-Create an array of 10 random numbers
            int[] randomNumbers = new int[10];
            Random rnd = new Random();
            System.Random rnd2 = new System.Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();


        }
    }
}
