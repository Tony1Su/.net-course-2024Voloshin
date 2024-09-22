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

        public Employment EmploymentType { get; }

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


    }
}
