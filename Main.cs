using System;
using System.Collections.Generic;

namespace ClassPractice
{
    class Company
    {
        static void Main(string[] args)
        {
            Employee jonBonjovi = new Employee() {
                FirstName = "Jon",
                LastName = "BonJovi",
                Title = "Manager",
                startDate = new DateTime(2011, 1, 1)
            };
        }
    }

}