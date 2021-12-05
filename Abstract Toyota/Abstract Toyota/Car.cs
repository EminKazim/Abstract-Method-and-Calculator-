using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Toyota
{
    public abstract class Car
    {
        public int Fuel { get; set; }
        public int Engine { get; set; }
        public abstract void GetFuelType();
            public virtual void FuelNeed()
        {
            Console.WriteLine("  ");
        }
       
    }
}
