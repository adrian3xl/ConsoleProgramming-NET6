using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Person
    {
      

         public string FirstName { get; set; }
          public  string LastName { get; set; }
         public   int Age { get; set; }


        private double Salary { get; set; }




        public void SetSalary(double salary)
        {

            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary;
        }

       public string GetFullName()
        {
       
            return $"{FirstName} {LastName}";
        }


        public string GetFullName(string MiddleName)
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

    }
}
