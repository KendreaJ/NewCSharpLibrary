using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypeChallange
{
    class Program
    {
        static void Main(string[] args)
        {

            //BRONZE
            int luckyNumber;
            bool isMarried = true;
            string myName = "Kendrea";
            string lastName = "Williams";
            double pi = 3.14;

            Console.WriteLine(pi);
            Console.WriteLine(isMarried);
            

            //Silver
            string fullName = "Kendrea" + "lastName";
            Console.WriteLine(fullName);
            Console.ReadLine();

            //GOld
            string birthYear = "1980";
            int year= Convert.ToInt32(birthYear);
            string age = "30";
            int numAge = Convert.ToInt32(age);
            numAge = numAge + 1;
           

            Console.WriteLine(numAge);
            Console.ReadLine();

            //Console.WriteLine("I was born in" + year);
            //Console.ReadLine();
               

        }
    }
}
