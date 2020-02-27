using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens10
{
    class Program
    {
        static void Main(string[] args)
        {
            var motor = new Motor();
            motor.Model = "ZZZ";
            Console.WriteLine(Search.SearchCar(motor.Model));

        }
    }
    public class Car
    {
        public string Name { get; set; }
        public Motor Motor { get; set; }

    }

    public class Motor
    {
        public string Model { get; set; }
        public Car car { get; set; }
    }
    public class Search
    {
        public static string SearchCar(string motormodel)
        {
            var data = new MotorData();
            foreach (var item in data.Motors)
            {
                if (item.Model == motormodel)
                {
                    return item.car.Name;
                }
            }
            return null;

            
        }
    }

    public class MotorData
    {
        public List<Motor> Motors = new List<Motor>
        {
            new Motor() { Model = "XXX", car = new Car() { Name = "BMW"} },
            new Motor() { Model = "YYY", car = new Car() { Name = "Audi"} },
            new Motor() { Model = "ZZZ", car = new Car() { Name = "Ferarri"} }
        };
    }
}
