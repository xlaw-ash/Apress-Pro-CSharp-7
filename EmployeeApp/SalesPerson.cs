using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }
        public SalesPerson(string name, int id, int age, float pay, string ssn, int salesNumber)
            : base(name, id, age, pay, ssn)
        {
            SalesNumber = salesNumber;
        }
    }
}
