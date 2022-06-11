// See https://aka.ms/new-console-template for more information





Console.WriteLine("Please ener number");
int number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please ener number");
int number2 = Convert.ToInt32(Console.ReadLine());


try
{
    int quotient = number1 / number2;
    Console.WriteLine($"Result is {quotient}");
}
catch (Exception ex)
{

    Console.WriteLine($"You can´t perform that operation : 0 devision is unacceptable : {ex.Message}");
}catch
{

    throw;
}
finally
{
    Console.WriteLine("end of program");
}