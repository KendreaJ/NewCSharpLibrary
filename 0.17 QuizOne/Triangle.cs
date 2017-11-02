using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_QuizOne
{
    class Triangle : Shape
    //How to inherit from another class

    {
        //Constructors
        public Triangle(int tbase, int theight)
        {
            this.TBase = tbase;
            this.THeight = theight;
        }

        //properties that are set. Tbase, Theight and Area

        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }
       


        //the constructor set up with two parameters

        //Methods of implementation
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2;
            return this.TArea;
        }


    }
}