using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTask
{
    internal class Galery
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }

        public Galery(string name, Car[] cars) 
        {
            Name = name;
            Cars = cars;

        }
        public void GetGalleryCarShow()
        {
           foreach (var car in Cars)
            {
                car.GetInfoCar();
            }
        }
        public void GetGallerCarById(int id)
        {
            foreach(var car in Cars)
            {
                if(car.Id == id)
                {
                    car.GetInfoCar();
                }
            }
        }
        public void SumCar()
        {
            int sum = 0;
            foreach(var car in Cars)
            {
                sum += car.Price;
            }
            Console.WriteLine(sum);
        }
    }
}
