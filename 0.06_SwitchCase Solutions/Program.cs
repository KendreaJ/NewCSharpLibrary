using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Jay";

            switch (friend)
            {
                case "jay":
                    Console.WriteLine("Hey Jay.");
                    break;
                case "paul":
                    Console.WriteLine("Paul is pretty cool.");
                    break;
                case "kenn":
                    Console.WriteLine("Silent master Kenn...");
                    break;
                default:
                    Console.WriteLine("I don't know you.");
                    break;
            }

            int age = 15;

            switch (age)
            {
                case 21:
                    Console.WriteLine("You can drink alcohol.");
                    break;
            }
        }
    }
}