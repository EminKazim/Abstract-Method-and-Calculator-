using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Toyota
{
    public class ToyotaCamry : Car
    {
        public override void GetFuelType()
        {
            Console.WriteLine("Camry's fuel is Gas");
        }
    }
}
