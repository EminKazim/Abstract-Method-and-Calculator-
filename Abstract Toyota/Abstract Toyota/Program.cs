using System;

namespace Abstract_Toyota
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota_Prius car1 = new Toyota_Prius();
            car1.GetFuelType();
            ToyotaCamry car2 = new ToyotaCamry();
            car2.GetFuelType();
        }
    }
}
