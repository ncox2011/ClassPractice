using System;
using System.Collections.Generic;

namespace ClassPractice
{

    public class Company{
        public string CompanyName {get;}
        public HashSet<Employee> EmployeeList = new HashSet<Employee>();
        public DateTime DateFounded {get;}
   ListEmployees(){
       foreach (Employee employee in EmployeeList)
       {
           Console.WriteLine($"{FirstName} {LastName}");
       }
    }

   }
}