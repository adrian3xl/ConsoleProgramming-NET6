// See https://aka.ms/new-console-template for more information

DateTime date = new DateTime(); //empty datetime



DateTime dateofbirth = new DateTime(1999, 12, 31);
Console.WriteLine(dateofbirth);

DateTime now =  DateTime.Now;
Console.WriteLine(now);


DateOnly datealone = new DateOnly(1999, 12, 31);
Console.WriteLine(datealone);