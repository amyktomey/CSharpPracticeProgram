using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using CSharpPracticeProgram;
using System.Linq.Expressions;
using System.Text.Json;

Console.WriteLine("Welcome to the program. Please choose from the following menu options:");
Console.WriteLine("1: Add an employee");
Console.WriteLine("2: View all current employees");
Console.WriteLine("3: Remove an employee by name");
Console.WriteLine("4: Exit");

List<Employee> employees = new();

var _ = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var fileText = File.ReadAllText("employees.json");
var deserialized = JsonSerializer.Deserialize<List<Employee>>(fileText);
employees.AddRange(deserialized);

string userInput = Console.ReadLine();

while  (userInput != "4")
{
    if (userInput == "1")
    {
        employees = Menu.AddEmployee(employees);
    }
    else if (userInput == "2")
    {
        Menu.DisplayEmployees(employees);
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Enter the name of the employee to remove");
        var name = Console.ReadLine();
        Menu.RemoveEmployee(employees, name);
    }
    else if (userInput == "4")// Exit
    {
       
    }
    Console.WriteLine("What next?");
    userInput = Console.ReadLine();

}

var json = JsonSerializer.Serialize(employees);
File.WriteAllText("employees.jaon", json);