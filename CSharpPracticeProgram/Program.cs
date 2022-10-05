using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using CSharpPracticeProgram;
using System.Linq.Expressions;

Console.WriteLine("Welcome to the program. Please choose from the following menu options:");
Console.WriteLine("1. Add an employee");
Console.WriteLine("2. View all current employees");
Console.WriteLine("3. Remove an employee by name");

List<Employee> employees = new List<Employee>();

if (Console.ReadLine() == "1")
{
    employees = Menu.AddEmployee(employees);
}
