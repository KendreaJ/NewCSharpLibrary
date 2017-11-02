using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Getters_and_Setters
{
    class Employee
    {
       //Backing fields
        private int _id;
        private string _name;
        private string _workQuote;

        //properties
        //Prop tab tab-sets up the property structure
        //propfull-returns the value of the property
        //How to add getter setters

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Invalid Employee Name.");
                _name = value;
            }
        }

        //Methods
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote; 
        }
        public string GetQuote()
        {
            return this._workQuote;
        }

    }
}
