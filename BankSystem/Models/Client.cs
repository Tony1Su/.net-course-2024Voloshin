namespace BankSystem.Models;

public class Client : Person
{
    public Client(string firstName, string lastName, int age, string phoneNumber) : base(firstName, lastName, age, phoneNumber)
    {
    }
}