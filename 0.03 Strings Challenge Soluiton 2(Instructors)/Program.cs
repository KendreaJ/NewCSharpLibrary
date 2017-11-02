using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            //Currency
            double cash = 563.3265;
            Console.WriteLine("{0:C}", cash);

            //Percentage
            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);

            //Phone Number
            double phoneNumber = 8123648944;
            string formatedPhoneNumber = phoneNumber.ToString("(###) ### - ####");
            Console.WriteLine(formatedPhoneNumber);
            Console.WriteLine("{0:(###) ### - ####}", phoneNumber);


        }
    }
}