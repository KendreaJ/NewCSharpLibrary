using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Game_Build_Along
{
    class Player : Character
    {
        //Constructors: (CTOR tab tab) abstracts of the character
        public Player(string name, Specialization role)
        {
            this.Name = name;
            this.Role = role;
            this.IsALive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }
        //Properties of the player and the enemy
        public Specialization Role { get; set; }

        //Emuns-This is where you store diffent classes and weapon types, or actions of the character
        public enum Specialization
        {
            HorseMange,
            TrollCat,
            KnightTemplator,
            Demogorg,
            Vmapire,
            BovineFrog,
        }
        //How to declare a players actions
        public enum Action
        {
            Attack,
            Run,
            Hide
        }
           
    }
}
