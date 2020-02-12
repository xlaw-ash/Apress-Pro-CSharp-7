using System;
using System.Collections.Generic;
using System.Text;

namespace BasicInheritance
{
    class Car
    {
        // Members
        public readonly int maxSpeed;
        private int currSpeed;

        // Properties
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if(currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }

        //Constructors
        public Car(int max)
        {
            maxSpeed = max;
        }
    }
}
