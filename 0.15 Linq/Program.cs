using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };
            
            //Set up your query
            IEnumerable<string> query = from i in instructors
                                       where i.Length == 4
                                       select i;
            //use a for each loop
            foreach (string name in query) 
            {
                //Console.WriteLine(name);
               
           }

            //Employee Lists
            IEnumerable<Employee> employees = new List<Employee>()
            {
                //properties
                new Employee {ID=1,Name="JohnBoy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=2,Name="Tammy",HireDate=new DateTime(2013,9,1)},
                new Employee {ID=3,Name="Clarence",HireDate=new DateTime(2014,5,15)},
                new Employee {ID=4,Name="Momma June",HireDate=new DateTime(2000,9,10},
                new Employee {ID=3,Name="Honey Boo boo",HireDate=new DateTime(2014,5,15)},
            };
            //Write names of employees after 2017
            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016


                                             orderby e.Name ascending
                                             select e;
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
                
            }
             

            Console.ReadLine();
        }
    }
}
