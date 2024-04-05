using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticTask
{
    internal class Car
    {
        public int Id;
        public static int Count;
        public string Name;
        public int Speed;
        public int Price;

        public Car(string name,int speed,int price)
        {
            Count++;
            Id = Count;
            Name = name;
            Speed = speed;
            Price = price;
        }
        public void GetInfoCar()
        {
            Console.WriteLine($"{Name} {Speed} {Price}");
        }

    }
}
