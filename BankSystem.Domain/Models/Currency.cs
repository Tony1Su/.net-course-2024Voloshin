namespace BankSystem.Domain.Models;

public struct Currency
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Currency(string name, int value)
    {
        Name = name;
        Value = value; 
    }

    // Метод, обновляющий сущность валюты
    public static Currency UpdateCurrency(Currency currency, string name, int value)
    {
        currency.Name = name;
        currency.Value = value;
        return currency;
    }
}