namespace BankSystem.Domain.Models;

public abstract class Person
{
    public Guid PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    // Конструктор
    protected Person(Guid personId, string firstName, string lastName, int age, string phoneNumber, string address)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PhoneNumber = phoneNumber;
        Address = address;  // Исправлено на Address
    }
}