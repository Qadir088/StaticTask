using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mercedes", 200, 10000);
            Car car1 = new Car("BMW", 280, 15000);
            Car car2 = new Car("Audi", 240, 18000);
            Car car3 = new Car("Opel", 180, 8000);
            Car[] cars = {car,car1,car2,car3};
            Galery galery = new Galery("QadirsQalleri",cars);


            galery.GetGallerCarById(2);
        }
    }
}
