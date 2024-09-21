using System;
using BankSystem.Domain.Models;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            // Создание сотрудника
            Employee _employee = new Employee(
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
            
            Console.WriteLine("Контракт до обновления:");
            Console.WriteLine(employee.Contract);

            // Обновление контракта
            void UpdateEmployeContract(Employee _employee)
            {
            }
            Console.WriteLine("Контракт после обновления:");
            Console.WriteLine(employee.Contract);

            // Создание валюты
            Currency currency = new Currency ("USD",  13 );
            currency = UpdateCurrency(currency, "Euro", 10);
        }
    }
}