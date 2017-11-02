using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Game_Build_Along
{
    public abstract class Character
    {
        //AddConstants-All constants should be capitalized
        const int MIN_HEALTH = 0;

        //Add Properties-such as name 
        public string Name { get; set; }
        public bool IsALive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Energy { get; set; }
        public double CritChance { get; set; }

        //Methods-how to get the character to move.  Set up variables inside of the methods.  

        public int Attack()
        {
            Random rnd = new Random();
            int spread = rnd.Next(-5, 6);
            int damage = this.AttackPower + spread;
            bool isCrit = IsCritical();

            return isCrit ? damage* 2 : damage;
        }

        public bool IsCritical()
        {
            Random rnd = new Random();
            bool isCrit = rnd.Next(0, 101) < (this.CritChance * 100) ? true : false;
            return isCrit;
            
        }
    }
}
