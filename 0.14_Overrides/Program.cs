using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);
            Circle newCircle = new Circle(4);

            //To view the area of a square
            Console.WriteLine($"Area = {newSquare.Area()}");
            Console.WriteLine($"Area ={newCircle.Area()}");

        }
    }
}
