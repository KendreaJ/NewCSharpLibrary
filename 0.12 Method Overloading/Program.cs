using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player();
            me.Attack(2500);
            me.Attack(100, "dusty stick");
            me.Attack(500, "Katana", 90);

     //Using Returns
        int num1 = 3;
        int num2 = 5;

        int product = num1 * num2;
        int product2 = me.Mutiply(num1, num2);

            
       }
    }
}
