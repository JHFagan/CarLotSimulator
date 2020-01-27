using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot1 = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();
            var car2 = new Car(1204, "Ancient Honda", "Chariot", "*whinneing*", "*Yelling Romanly*", true);
            var car3 = new Car()
            {
                Year = 2004 ,
            Make = "Honda",
            Model = "CRV",
            EngineNoise = "vwooosh",
            HonkNoise = "Honka-Honka",
            IsDriveable = false
            };

            //Set the properties for each of the cars
            car1.Year =2001;
            car1.Make ="GM" ;
            car1.Model ="Oldsmobile";
            car1.EngineNoise = "chugachugachuga" ;
            car1.HonkNoise = "beep-beep bitch" ;
            car1.IsDriveable = true;

            //Call each of the methods for each car
            car1.MakeEngineNoise("vroooooooom");
            car1.MakeHonkNoise("beeeeeeep");
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();


            lot1.Lot.Add(car1);
            lot1.Lot.Add(car2);
            lot1.Lot.Add(car3);

            foreach (var car in lot1.Lot)
            {
                Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
