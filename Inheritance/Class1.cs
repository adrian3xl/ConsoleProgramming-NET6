using System;



Cube cube = new Cube();

var triangle = new Triangle();

Console.WriteLine("Please enter lenght value");
double lenght = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter height value");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter width value");
double width = Convert.ToDouble(Console.ReadLine());


cube.Width = width;
cube.Height = height;   
cube.Lenght = lenght;

Console.WriteLine("the area of the cube is " + cube.Area());


