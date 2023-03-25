using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;
using Task3.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        EmployeeOne[] company = new EmployeeOne[]
        {
            new Contractor { FirstName = "Bob", LastName = "Bobert", Salary = 1000 },
            new Contractor { FirstName = "Rick", LastName = "Rickert", Salary = 900 },
            new Manager { FirstName = "Mona", LastName = "Monalisa", Salary = 2000 },
            new Manager { FirstName = "Igor", LastName = "Igorsky", Salary = 1800 },
            new SalesPerson { FirstName = "Lea", LastName = "Leova", Salary = 1500 },
        };

        CEO ceoName = new CEO
        {
            FirstName = "Ron",
            LastName = "Ronsky",
            Salary = 1500,
            Employees = company,
            Shares = 1000,
        };

        ceoName.AddSharesPrice(1.3);

        Console.WriteLine("CEO:");
        Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2}", ceoName.FirstName, ceoName.LastName, ceoName.Salary);
        Console.WriteLine("Salary of CEO is: {0}", ceoName.GetSalary());
        ceoName.PrintEmployees();
    }
}
