namespace ConsoleApp.Models;

public abstract class Car
{
    private string _brand;
    private string _model;
    private int _year;

    /// <summary>
    /// стандартный конструктор
    /// </summary>
    public Car(string brand, string model, int year)
    {
        _brand = brand;
        _model = model;
        _year = year;
    }
    
    /// <summary>
    /// создаем метод
    /// </summary>
    public abstract void StartEngine();

    // Создаеме гетеры для обращения к приватным полям
    public string Brand
    {
        get { return _brand; }
    }

    public string Model
    {
        get { return _model; }
    }

    public int Year
    {
        get { return _year; }
    }


    public void ShowInfo()
    {
        Console.WriteLine($"Автомобиль: {Brand} {Model}, год: {Year}");
    }
}