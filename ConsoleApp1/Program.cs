using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCar;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("Матвей","B");

            Auto auto1 = new Auto("Mercedes-Benz", "а111аа");
            Auto auto2 = new Auto("BMW", "в777ор");
            Auto auto3 = new Auto("Toyta", "т444оп");

            driver.AddAuto(auto1);
            driver.AddAuto(auto2);
            driver.AddAuto(auto3);

            driver.ShowAll();

            Console.ReadLine();
        }
    }
}
