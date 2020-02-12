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

        public override void GiveBonus(float amount)
        {
            int salesBonus = 1;
            if(SalesNumber >= 0 && SalesNumber <= 100) { salesBonus = 10; }
            else if(SalesNumber >= 101 && SalesNumber <= 200) { salesBonus = 15; }
            else if(SalesNumber > 200) { salesBonus = 20; }
            else { salesBonus = 1; }

            base.GiveBonus(amount * salesBonus);
        }
    }
}
