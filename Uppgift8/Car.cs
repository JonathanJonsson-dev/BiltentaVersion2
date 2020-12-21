using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift8
{
    public class Car
    {
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string color, string licensePlate, string make, string model)
        {
            Color = color;
            LicensePlate = licensePlate;
            Make = make;
            Model = model; 
        }

    }
}
