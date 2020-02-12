using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager() { }
        public Manager(string name, int id, int age, float pay, string ssn, int stockOptions)
            : base(name, id, age, pay, ssn)
        {
            StockOptions = stockOptions;
        }
    }
}
