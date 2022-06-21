// See https://aka.ms/new-console-template for more information

class Triangle :Shape, IShape
{
    public double angle { get; set; }

    public double Area()
    {
        return Lenght * Width;
    }
}