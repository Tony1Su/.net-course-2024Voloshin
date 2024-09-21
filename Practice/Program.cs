using System;
using BankSystem.Domain.Models;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            // Создание сотрудника
            var _employee = new Employee(
                Guid.NewGuid(),
                "John",
                "Smith",
                35,
                "123-456-7890",
                "123 Lenin St",
                Guid.NewGuid(),
                "",
                "2019-08-07",
                Employee.Employment.FullTime
            );

            // Обновление контракта
            UpdateEmployeContract(_employee);

            // Создание валюты
            Currency currency = new Currency("USD", 13);
            Console.WriteLine("Валюта: " + currency.Name);
            Console.WriteLine("Значение: " + currency.Value);
        }

        private static void UpdateEmployeContract(Employee employee)
        {
            Console.WriteLine("Контракт до обновления:");
            Console.WriteLine(employee.Contract);
            Random random = new Random();
            int contractNumber = random.Next(11111, 99999);
            string contractEmploymentType = employee.EmploymentType == Employee.Employment.FullTime ? "на полный день" : "на неполный день";
        
            employee.Contract =
                $"\'Договор номер {contractNumber}. " +
                $"Договор заключен с {employee.FirstName} {employee.LastName}, " +
                $"проживающим по адресу {employee.Address}, " +
                $"контактный телефон {employee.PhoneNumber} " +
                $"от {employee.EmploymentDate}. Тип занятости: {contractEmploymentType}.\'";
            Console.WriteLine("Контракт обновлен:");
            Console.WriteLine(employee.Contract);
        }
    }

    public class Currency
    {
        public string Name { get; set; }
        public decimal Value { get; set; }

        public Currency(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}