using System.Data;
using Task2.Domain.Enums;
using Task2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contractor : Employee
{
    public double WorkHours { get; set; }
    public int PayPerHour { get; set; }
    public Manager Responsible { get; set; }
    public Manager Department { get; set; }


    public Contractor(string firstName, string lastName, Role role, double salary) : base(firstName, lastName, role, salary)
    {
        Department = Department;
    }

    public override double GetSalary()
    {
        double salary = WorkHours * PayPerHour;
        Salary = salary;
        return salary;
    }

    public string CurrentPosition()
    {
        return Responsible.Departments;
    }
}
