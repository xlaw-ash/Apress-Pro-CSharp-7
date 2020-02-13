using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IBeverage
    {
        // All properties and methods in Interface are by default public and abstract. So, no need to add access modifier.

        // Properties
        double Milk { get; set; }
        int Sugar { get; set; }
        double Water { get; set; }
        bool Ice { get; set; }
        bool Hot { get; set; }

        // Methods
        void Make();
    }
}
