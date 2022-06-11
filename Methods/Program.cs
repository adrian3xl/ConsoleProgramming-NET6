// See https://aka.ms/new-console-template for more information


void PrintName(){

    Console.WriteLine("Adrian");

};

void Add(int num1, int num2)
{

    Console.WriteLine($"The sum of {num1} and {num2} is equal to {num1 + num2}");

};



//value returning fuction

int largestnumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
    {

        largest = num2;

    }
    else if (largest < num3)
    {
        largest = num3;

    }



    return largest;

}




//value bings to values in void functions

PrintName();


Console.WriteLine("Please ener number");
int number1 = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("Please ener number");
int number2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please ener number");
int number3 = Convert.ToInt32(Console.ReadLine());

Add(number1,number2);
Console.WriteLine("end of void function");



int result = largestnumber(number1, number2,number3);
Console.WriteLine($"The largest value is {result}");