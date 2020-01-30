using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
       public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
       {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
       }
        public Car() { CarLot.numberOfCars++; }
       public int Year { get; set; }
       public string Make { get; set; }
       public string Model { get; set; }
       public string EngineNoise { get; set; }
       public string HonkNoise { get; set; }
       public bool IsDriveable { get; set; }

       public void MakeEngineNoise(string engineNoise)
       {
            EngineNoise = engineNoise;
            Console.WriteLine (EngineNoise);
       }
       public void MakeEngineNoise()
       {
            Console.WriteLine(EngineNoise);
       }

       public void MakeHonkNoise (string honkNoise)
       {
            HonkNoise = honkNoise;
            Console.WriteLine(HonkNoise);
       }
       public void MakeHonkNoise()
       {
            Console.WriteLine (HonkNoise);
       }

    }
}
