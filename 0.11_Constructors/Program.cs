using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jayStudent = new Student() ;
            jayStudent.FirstName = "jay";
            jayStudent.LastName = "Jackson";
            jayStudent.Grade = 1;
            jayStudent.Age = 5;

            Student jayStudent = new Student("Jay:");
            Student paulStudent = new Student(Paul","Oconner", 5, 1);
            Student kendreaStudent = new Student("Kendrea");

           
            }
        }
    }
