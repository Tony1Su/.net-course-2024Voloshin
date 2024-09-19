namespace BankSystem.Models;

public class Employee : Person
{
    public Employee(string firstName, string lastName, int age, string phoneNumber) : base(firstName, lastName, age, phoneNumber)
    {
    }
}