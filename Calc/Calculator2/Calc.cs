using System;

namespace Calculator
{
    public class Calc
    {
        public void CalcMethd()
        {
            Console.WriteLine("Enter first digit:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation (+,-,*,/):");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter second digit:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n + m);
            }
            else if (operation == "-")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n - m);
            }
            else if (operation == "*")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n * m);
            }
            else if (operation == "/")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n / m);
            }
            else
            {
                Console.WriteLine("Result:");
                Console.WriteLine("Something get wrong");
            }

        }
    }

}