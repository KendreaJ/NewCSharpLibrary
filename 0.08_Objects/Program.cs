using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut PaulDonut = new Donut();
            Donut KennDonut = new Donut();
            Donut KendreaDonut = new Donut();

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = "0";
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99M;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            KendreaDonut.Filling = "Cherry Jelly";
            KendreaDonut.Price = "3.00";
            KendreaDonut.Type = "Jelly";
            KendreaDonut.IsSpecial = true;


            Console.WriteLine(PaulDonut);
            Console.WriteLine(PaulDonut.Filling);
            Console.ReadLine();

        }
    }
}
