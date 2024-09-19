namespace ConsoleApp.Models;

public class Truck : Car
{
    public int LoadCapacity { get; private set; }

    public Truck(string brand, string model, int year, int loadCapacity)
        : base(brand, model, year)
    {
        LoadCapacity = loadCapacity;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model} завелся с тяжелым звуком.");
    }

    public void LoadCargo(int weight)
    {
        if (weight > LoadCapacity)
        {
            Console.WriteLine("Перегрузка! Груз слишком тяжелый.");
        }
        else
        {
            Console.WriteLine($"Груз в {weight} кг загружен.");
        }
    }
}