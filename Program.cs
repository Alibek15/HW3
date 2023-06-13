using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car Car2 = new Car("Mersedes");
            Car[] car3Cars = new Car[5];
            for (int i = 0; i < car3Cars.Length; i++)
            {
                car3Cars[i] = new Car();
            }

            
            Console.WriteLine();
            Car1.MaxSpeed = 9;
            Console.WriteLine(Car1.MaxSpeed);
            Car1.Print(ref Car1);
            Console.WriteLine();
            Car1.Print();
            Console.WriteLine();
            Console.WriteLine(Car.carForeign);
            Console.ReadKey();
             System.Environment.Exit(1);
        }
    }
}
