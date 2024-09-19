namespace BankSystem.Models;

public abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private string _phoneNumber;

    public Person( string firstName, string lastName, int age, string phoneNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _phoneNumber = phoneNumber;
    }
    
    public void SayHello()
    {
        Console.WriteLine($"Привет меня зовут {_firstName} {_lastName}");
    }
    
    public void SayPhoneNumber()
    {
        Console.WriteLine($"Привет меня зовут {_firstName} {_lastName}. Вот моя номер телефона {_phoneNumber}");
    }
}

// фамилия, имя, возраст, телефон, номер паспорта 
