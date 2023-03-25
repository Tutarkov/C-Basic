using System;

class EmployeeOne
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public virtual double GetSalary()
    {
        return Salary;
    }
}

class Contractor : EmployeeOne
{
}

class Manager : EmployeeOne
{
}

class SalesPerson : EmployeeOne
{
}

class CEO : EmployeeOne
{
    private double sharesPrice;

    public EmployeeOne[] Employees { get; set; }
    public int Shares { get; set; }
    public double SharesPrice
    {
        get { return sharesPrice; }
        private set { sharesPrice = value; }
    }

    public override double GetSalary()
    {
        return base.GetSalary() + Shares * SharesPrice;
    }

    public void AddSharesPrice(double price)
    {
        SharesPrice = price;
    }

    public void PrintEmployees()
    {
        Console.WriteLine("Employees:");
        foreach (EmployeeOne employee in Employees)
        {
            Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
        }
    }
}
