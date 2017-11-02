using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Game_Build_Along
{
    class Enemy : Character
        //What makes a constructor unique?  It has not return type.  It has an access modifer
        //Constructors should have the exact same name as the class
    {
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.IsALive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 15;
            this.CritChance = 0.30;
        }
    }
}
