using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string year)
        {
            Year = year;
        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
        public void IsItDriveable()
        {
            if (IsDriveable == "yes")
            {
                Console.WriteLine($"{IsDriveable}, this car is driveable.");
            }
            else
            {
                Console.WriteLine($"{IsDriveable}, this car is not driveable.");

            }
        }

      


        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
}
