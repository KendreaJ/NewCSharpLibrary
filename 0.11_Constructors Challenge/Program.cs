﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsPhoneChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            MobilePhone jayPhone = new MobilePhone("Motorola", "DynaTAC");
            MobilePhone paulPhone = new MobilePhone("Nokia", "7650");
            MobilePhone kennPhone = new MobilePhone("Sony", "Ericsson P800");
            MobilePhone chrisPhone = new MobilePhone("Nokia", "N-GAGE");
            MobilePhone jennPhone = new MobilePhone("BlackBerry", "850");

            Console.WriteLine($"I own a {jayPhone.Make} {jayPhone.Model}");

            paulPhone.PrintPhone();
            kennPhone.PrintPhone();












            //SILVER
            //MobilePhone jayPhone2 = new MobilePhone("Jay", "Motorola", "DynaTAC");
            //MobilePhone paulPhone2 = new MobilePhone("Paul", "Nokia", "7650");
            //MobilePhone kennPhone2 = new MobilePhone("Kenn","Sony", "Ericsson P800");
            //MobilePhone chrisPhone2 = new MobilePhone("Nokia", "N-GAGE");
            //MobilePhone jennPhone2 = new MobilePhone("BlackBerry", "850");
            //List<MobilePhone> phonesList = new List<MobilePhone>
            //{
            //    jayPhone,
            //    paulPhone,
            //    kennPhone,
            //    chrisPhone,
            //    jennPhone
            //};
        }
    }