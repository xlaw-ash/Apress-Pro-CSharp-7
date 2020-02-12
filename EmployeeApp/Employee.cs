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
        public readonly string empSSN;

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
        public int Age { get; set; } // Auto Property is used when there is no logic in get and set.

        // Constructors
        public Employee() { }
        public Employee(string name, int id, int age, float pay)
        {
            // Use properties in constructors for get and set logic
            // instead of implementing that logic in constructor
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
        }
        public Employee(string name, int id, int age, float pay, string ssn) : this(name, id, age, pay)
        {
            empSSN = ssn;
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
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
