using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    class Circle : Shape 
    {
        //Constructors
        public Circle (int radius)
        {
            this.Radius = radius;
        }
        
        //Properties
        public int Radius { get; set; }


        //Methods
        public override double Area()
        {
            return Math.Pow(Radius, 2);
        }
    }
}

    }
}
