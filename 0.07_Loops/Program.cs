using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze Challenge
            int number = 5;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);      
            }
            //SilverChallenge
            int number = 0;
            while (number < 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }
            //Gold Challenge

            Console.ReadLine();

        }
    }
}
