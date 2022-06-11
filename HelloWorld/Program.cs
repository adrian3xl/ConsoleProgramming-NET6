// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string ItemName = string.Empty;
int value=0;

bool Instock;

Console.WriteLine("Please enter name of good");
ItemName = Console.ReadLine();

Console.WriteLine("Please enter a value for good");
value = Convert.ToInt32( Console.ReadLine());



Console.WriteLine("Please enter status if Instock (True or False)");
Instock = Convert.ToBoolean( Console.ReadLine());

Console.WriteLine("The name of item entered was:" + ItemName);
Console.WriteLine("The value of item is {0}", value);
Console.WriteLine("The status of stock is: {Instock}");