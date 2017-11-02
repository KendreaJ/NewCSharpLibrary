using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_CSharp_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        { 

            //BRONZE

            double cash = 999.99;
            Console.WriteLine("{0:c}", cash);
         

            //Percentage

            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);
           

            //Phone Number
            long phoneNumber = 3172949446;
            string number1 = phoneNumber.ToString("(###) ###-####");
            Console.WriteLine(number1);
            Console.ReadLine();
            
           
            

        }
    }
}
