using System;
using ConsoleApp.Models;

static class Program
{
    static void Main()
    {
        Car sedan = new PassengerСar("Toyota", "Camry", 2020);
        Car truck = new Truck("Volvo", "FH16", 2018, 20000);

        foreach (Car car in new Car[] { sedan, truck })
        {
            car.ShowInfo();
            car.StartEngine();
            
            if (car is Truck actualtruck)
            {
                actualtruck.LoadCargo(15000);
                actualtruck.LoadCargo(25000);
            }
        }
    }
}