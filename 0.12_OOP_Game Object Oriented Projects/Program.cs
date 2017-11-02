using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOP_Game_Object_Oriented_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Character myName = new Character();
            Player newHero = new Player();
            Enemy jenn = new Enemy();

      
            Console.WriteLine("Hello, wanderere.. \n"
                + "What be thy name?");
            newHero.Name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Nice to mee you, {newHero.Name}.");

            Console.WriteLine("Whats your specializaiton field?\n" +
                "1: Horse Mange\n" +
                "2: Troll Cat\n" +
                "3: Kight Templatetor\n" +
                "4: Demogorg\n" +
                "5: Sire Cena");
            Player.Specialization = int.Parse(Console.ReadLine());

              
            

              

        }
    }
}
