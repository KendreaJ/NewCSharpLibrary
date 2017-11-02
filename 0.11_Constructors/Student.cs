using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Constructors
{
    class Student
    {
       
        
        //Constructor with 3 parameters
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;

        }

        //Constructor with 4 parameters
        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }
        //Constructor with no name
        public Student()
        {

        }
        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        //Constuctor
        public Student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }

    }

    //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
      
    
            
        }
    
}  