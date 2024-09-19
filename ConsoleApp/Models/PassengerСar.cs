namespace ConsoleApp.Models;

public class PassengerСar : Car
{
    public PassengerСar(string brand, string model, int year)
        : base(brand, model, year)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model} завелась.");
    }
}