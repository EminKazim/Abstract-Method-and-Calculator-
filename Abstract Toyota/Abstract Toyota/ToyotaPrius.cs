using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Toyota
{
    public class Toyota_Prius : Car
    {
        public override void GetFuelType()
        {
            Console.WriteLine("Prius's fuel is Diesel");
        }
    }
}
