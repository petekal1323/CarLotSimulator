using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{

    public static int numberOfCars = 0;
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var vechicle in ParkingLot)
        {
            Console.WriteLine($"Year: {vechicle.Year}, Make: {vechicle.Make}, Model: {vechicle.Model}");
        }
    }
}