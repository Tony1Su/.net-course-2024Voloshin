namespace BankSystem.Domain.Models;

public class Client : Person
{
    public Guid ClientId { get; set; }
    public decimal ClientBalance { get; set; }

    // Конструктор
    public Client(Guid personId, string firstName, string lastName, int age, string phoneNumber, string address,
        Guid clientId, decimal clientBalance)
        : base(personId, firstName, lastName, age, phoneNumber, address)
    {
        ClientId = clientId;
        ClientBalance = clientBalance;
    }
}