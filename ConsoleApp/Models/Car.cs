namespace ConsoleApp.Models;

public abstract class Car
{
    private string _brand;
    private string _model;
    private int _year;

    public Car(string brand, string model, int year)
    {
        _brand = brand;
        _model = model;
        _year = year;
    }

    public abstract void StartEngine();

    public string Brand => _brand;
    public string Model => _model;
    public int Year => _year;

    public void ShowInfo()
    {
        Console.WriteLine($"Автомобиль: {Brand} {Model}, год: {Year}");
    }
}