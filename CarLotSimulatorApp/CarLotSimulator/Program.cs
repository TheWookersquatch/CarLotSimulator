using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot1 = new CarLot();

            lot1.CarsOnLot = new List<Car>();
            
            Car car1 = new Car();
           
            car1.Make = "Toyota";
            car1.Model = "Sienna";
            car1.Year = "2010";
            car1.HonkNoise = "burrrrrp";
            car1.EngineNoise = "chugga-chugga";
            car1.IsDriveable = "Yes";
            
            Car car2 = new Car("1920");
            car2.Make = "Ford";
            car2.Model = "Model-T";
            car2.HonkNoise = "baaRUUUUba";
            car2.EngineNoise = "sputter-sputter";
            car2.IsDriveable = "No";
            
            Car car3 = new Car("2021", "Tesla", "S", "...um...is it on?", "CHU-CHU", "Yes");
       
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            car1.IsItDriveable();
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            car2.IsItDriveable();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            car3.IsItDriveable();
            lot1.CarsOnLot.Add(car1);
            lot1.CarsOnLot.Add(car2);
            lot1.CarsOnLot.Add(car3);
          
            foreach (var car in lot1.CarsOnLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }





            
        }
    }
}
