namespace BankSystem.Domain.Models
{
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

        // public void UpdateEmployeContract()
        // {
        //     Console.WriteLine("Контракт до обновления:");
        //     Console.WriteLine(Contract);
        //
        //     Random random = new Random();
        //     int contractNumber = random.Next(11111, 99999);
        //     string contractEmploymentType = EmploymentType == Employment.FullTime ? "на полный день" : "на неполный день";
        //
        //     Contract =
        //         $"Договор номер {contractNumber}. " +
        //         $"Договор заключен с {FirstName} {LastName}, " +
        //         $"проживающим по адресу {Address}, " +
        //         $"контактный телефон {PhoneNumber} " +
        //         $"от {EmploymentDate}. Тип занятости: {contractEmploymentType}.";
        //
        //     Console.WriteLine("Контракт обновлен:");
        //     Console.WriteLine(Contract);
        // }
    }
}
