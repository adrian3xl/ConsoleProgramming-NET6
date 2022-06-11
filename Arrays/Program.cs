// See https://aka.ms/new-console-template for more information

int[] grades = new int[5];



for(int i = 0; i < grades.Length; i++)
{

    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("The grades entered are");

for (int i = 0; i < grades.Length; i++)
{

    Console.WriteLine(grades[i]);

}
