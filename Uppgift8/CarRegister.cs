using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift8
{
    public class CarRegister
    {
        public List<Car> Cars { get; set; }

        public CarRegister()
        {
            Cars = new List<Car>(); // Nyar upp listan Cars som innehåller Car
        }

        public bool AddCar(Car car)
        {
            Cars.Add(car);
            return true;
        }
    }
}
