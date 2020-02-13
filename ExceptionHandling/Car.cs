using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class Car
    {
        // Members
        private int carSpeed;

        // Properties
        public int Speed
        {
            get { return carSpeed; }
            set
            {
                if (value > 100)
                {
                    carSpeed = 0;
                    throw new Exception($"Sorry! Due to speed={value} exceeding 100 MPH, the engine is heated up. Please wait till it cools down.");
                }
                else { carSpeed = value; }
            }
        }
        public bool Radio { get; set; }
        public bool Safe { get; set; }

        // Constructors
        public Car() { }
        public Car(int speed) { Speed = speed; Radio = false; Safe = false; }
        public Car(int speed, bool radio) : this(speed) { Radio = radio; Safe = false; }
        public Car(int speed, bool radio, bool sport) : this(speed, radio) { Safe = sport; }

    }
}
