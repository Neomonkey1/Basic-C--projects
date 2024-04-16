﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate superclass 
            Employee employee = new Employee();

            //  Initialize employee object 
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //  Calling superclass method
            employee.SayName();

            Console.ReadLine();
        }
    }
}
