using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_What_is_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance allows you to define a child class
            //that resuises the behaviors of the parent class
            //the Parent class is the base class
            //the Child class is the derived class
            //Inheritance only applies to classes and interfaces

            
            //Example
public class A
        {
            private int value = 10;

            public class B : A
            {
                public int GetValue()
                {
                    return this.value;
                }
            }
        }

        //This is an example

        public class Example
        {
            public static void Main(string[] args)
            {
                var b = new A.B();
                Console.WriteLine(b.GetValue());
            }
        }
        // The example displays the following output:
        //       10
    }
}
}
