using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02__BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15; // range: -2,147,483,648 to 2,147,483,647
            int number1 = 15;
            int number2 = 5;
            int number3 = 10;

            byte myByte = 253; // range:0-255

            char myLetter ='A';  // range: any unicode type of character

            string myName = "Kendrea";  //range: up to 2 gigs of unicode character

            bool myTruth = true;



            
            //Notes
            //Declaration- Comments are good for communication and instructional reminders
            //<type> <VariableName> <optional initializer>; 

            int age;
            string country;

            // Initializaiton= When you set the code to run.  It must be set up on the Console
            age = 41;
            Console.WriteLine(age);
            age = 42;
            Console.WriteLine(age);

            Console.ReadLine();
            

           
            

        }
    }
}
