using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot1 = new CarLot();
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var car1 = new Car();
            car1.Year = 2020;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.IsDriveable = true;
            
            car1.MakeEngineNoise("Vroom Vroom");
            car1.MakeHonkNoise("Beep Beep");
            
            carLot1.ParkingLot.Add(car1);
            
            
            var car2 = new Car()
            {
                Year = 2021, 
                Make = "Honda", 
                Model = "Civic", 
                IsDriveable = true
            };

            car2.MakeEngineNoise("Vroom");
            car2.MakeHonkNoise("Honk");
            
            carLot1.ParkingLot.Add(car2);
            
            var car3 = new Car(make: "Ford", model: "Mustang", year: 2022, isDriveable: true);
            car3.MakeEngineNoise("VroOOOOOOOOOom VroOOOOOOOOOOOOOOOOom");
            car3.MakeHonkNoise("Hoooooooooooooooooonk"); 
            
            carLot1.ParkingLot.Add(car3);
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLot1.CheckCars();
        }
    }
}
