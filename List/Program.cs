// See https://aka.ms/new-console-template for more information

List<string> names = new List<string>();

string name = string.Empty;


names.Add("Adrian");

//Console.WriteLine("Enter Name");


while (!name.Equals("-1"))
{
    Console.WriteLine("Enter Name");

    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }

}



foreach (string item in names)
{
    Console.WriteLine();
}