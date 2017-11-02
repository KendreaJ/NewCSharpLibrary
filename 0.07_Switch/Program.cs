using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Kendrea";

            switch (friend)
            {
                case "Kendrea":
                    Console.WriteLine("Hey Kendrea");
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool");
                    break;
                case "Kenn":
                    Console.WriteLine("Silent Master Kenn...");
                    break;
                default:
                    Console.WriteLine("I dont know you");
                    break;
                     

            }
        }
    }
}
