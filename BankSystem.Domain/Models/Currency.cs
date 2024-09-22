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
}