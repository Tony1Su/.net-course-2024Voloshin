namespace BankSystem.Domain.Models;

public class Employee : Person
{
    public Guid EmployeeId { get; set; }
    public string Contract { get; set; }
    public string EmploymentDate { get; set; }

    public enum Employment
    {
        FullTime,
        PartTime
    }

    public Employment EmploymentType { get; set; }

    // Конструктор
    public Employee(Guid personId, string firstName, string lastName, int age, string phoneNumber, string address,
        Guid employeeId, string contract, string employmentDate, Employment employmentType)
        : base(personId, firstName, lastName, age, phoneNumber, address)
    {
        EmployeeId = employeeId;
        Contract = contract;
        EmploymentDate = employmentDate;
        EmploymentType = employmentType;
    }

    public void UpdateEmployeContract()
    {
        Random random = new Random();
        int ContractNumber = random.Next(11111, 99999);
        string contractEmploymentType = null;
        if (EmploymentType == Employment.FullTime)
        {
            contractEmploymentType = "на полный день";
        }
        else if (EmploymentType == Employment.PartTime)
        {
            contractEmploymentType = "на полный день";
        }

        Contract =
            $" Договор номер {ContractNumber}/n Договор заключен с {FirstName} {LastName}, проживающим по адресу {Address}, контактный телефон {PhoneNumber} от {EmploymentDate} {contractEmploymentType}.";
        Console.WriteLine(Contract);
    }
}