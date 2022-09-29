using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using CSharpPracticeProgram;

Console.WriteLine("Welcome to your new job!");

Console.WriteLine("Please enter your name:");
var name = Console.ReadLine();

Console.WriteLine("Please enter your birthday:");
var birthdayInput = Console.ReadLine();

DateTime birthday;

while (!DateTime.TryParse(birthdayInput, out birthday))
{
    Console.WriteLine("Not a valid date, please try again:");
    birthdayInput = Console.ReadLine();
 }

Console.WriteLine("Please enter your salary:");
var salary = Console.ReadLine();

var employee = new Employee
{
    Name = name,
    Birthday = birthday,
    Salary = decimal.Parse(salary)
};

Console.WriteLine($"Welcome to the company, {employee.Name}! Your salary is {employee.Salary} and your birthday is {employee.Birthday.ToShortDateString()}.");

DateTime myNextBirthday = new(DateTime.Today.Year, employee.Birthday.Month, employee.Birthday.Day);

if (myNextBirthday > DateTime.Today)
{
    myNextBirthday = myNextBirthday.AddYears(1);
}

var daysUntilBirtday = (myNextBirthday - DateTime.Today).Days;

if (daysUntilBirtday == 0)
{
    Console.WriteLine("HAPPY BIRTHDAY!!!!");
}
else
{
    Console.WriteLine($"Your birthday will be in {daysUntilBirtday} days.");
}
