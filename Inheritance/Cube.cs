// See https://aka.ms/new-console-template for more information

class Cube : Shape, IShape
{
    public double Height { get; set; }

    public double Area()
    {
        return Height * Lenght;
    }
}