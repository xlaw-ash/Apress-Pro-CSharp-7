using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    class Employee
    {
        // Field Data
        private string empName;
        private int empID;
        private float currPay;

        //Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if(value.Length > 13)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters.");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return empID; }
            set { currPay = value; }
        }

        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            // Use properties in constructors for get and set logic
            // instead of implementing that logic in constructor
            Name = name;
            ID = id;
            Pay = pay;
        }

        // Methods
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayState()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
