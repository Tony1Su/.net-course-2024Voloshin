using System;
using ConsoleApp.Models;

static class Program
{
    static void Main(string[] args)
    {
        Car sedan = new PassengerСar("Toyota", "Camry", 2020);
        Car truck = new Truck("Volvo", "FH16", 2018, 20000);

        sedan.StartEngine();
        truck.StartEngine();

        sedan.ShowInfo();
        truck.ShowInfo();

        Truck actualtruck = truck as Truck;
        if (actualtruck != null)
        {
            actualtruck.LoadCargo(15000);
            actualtruck.LoadCargo(25000);
        }
    }
}