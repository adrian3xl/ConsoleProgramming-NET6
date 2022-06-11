// See https://aka.ms/new-console-template for more information


using ClassAndObjects;

Person person = new();

string MiddleName = string.Empty;


Console.WriteLine("Enter first name ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last name");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Middle Name");
 MiddleName= Console.ReadLine();



Console.WriteLine("Enter your age");
person.Age = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("Enter your Salary");
int salary = Convert.ToInt32( Console.ReadLine() );

person.SetSalary(salary);

//Console.WriteLine($"Your name is {person.FirstName}");
//Console.WriteLine($"Your name is {person.LastName}");

if (string.IsNullOrEmpty(MiddleName))
{
    Console.WriteLine("Your full name is" + person.GetFullName());

}
else
{

    Console.WriteLine("Your full name is" + person.GetFullName(MiddleName));
}



//Console.WriteLine("Your Full Name is: " + person.GetFullName());
Console.WriteLine($"Your name is: {person.Age}");
Console.WriteLine("Your Salary is: " + person.GetSalary());