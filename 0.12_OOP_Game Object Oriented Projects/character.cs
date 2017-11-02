using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOP_Game_Object_Oriented_Projects
{
    public abstract class Character
    {
        // Constants
        const int Min_Health = 0;


        //Properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int AttackLevel { get; set; }
        public int Stamina { get; set; }
        public int Luck { get; set; }
        public bool IsAlive { get; set; }

        //Abstract Class-Allows you to make sub classes based off the original class.  

        //Methods is different from a property.  Methods are the execution. (Class, type Value)
        public void GetPowerLevel()
        {
            Random rnd = new Random();
            int powerLevel = rnd.Next(1, 100);
            this.Level = powerLevel; 
        }

        


        //Attack Methods, creating the level of the attack from the enemy.  The attack is set by the damage property
        public int Attack(int attackLevel)
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, attackLevel);
            return damage;
        }



    


    }
}
