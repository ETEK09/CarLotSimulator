using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            Carlot lot = new Carlot();
            

            var michaelsCar = new Car();
            michaelsCar.Make = "Ford";
            michaelsCar.Model = "Focus";
            michaelsCar.Year = 2013;
            michaelsCar.EngineNoise = "vroom";
            michaelsCar.HonkNoise = "beep";
            michaelsCar.IsDrivable = true;

            lot.Cars.Add(michaelsCar);

            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Trusk",
                EngineNoise = "...",
                HonkNoise = "brummp",
                IsDrivable = false              

            };

            lot.Cars.Add(stevesCar);

            var justiceCar = new Car(2013, "Honda", "Civic", "vrrroooom", "boomboom", true);

            lot.Cars.Add(justiceCar);

            //Call each of the methods for each car

            michaelsCar.MakeEngineNoise();
            //Console.WriteLine($"The number of cars in the lot is: {Carlot.numberOfCars}");
            stevesCar.MakeEngineNoise();
            //Console.WriteLine($"The number of cars in the lot is: {Carlot.numberOfCars}");
            justiceCar.MakeEngineNoise();
            //Console.WriteLine($"The number of cars in the lot is: {Carlot.numberOfCars}");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars


            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"The number of cars in the lot is: {Carlot.numberOfCars}");

            foreach (var car in lot.Cars) 
            {
                Console.WriteLine($"Number of cars created: {car.Year} Make: {car.Make} Model: {car.Model} ");
          
            }
        }

    }
}
