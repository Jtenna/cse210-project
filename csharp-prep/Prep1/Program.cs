using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep1 World!");
//     }
// }


public class Blind
{
    public double _width;
    public double _height;
    public string _color;

    public double GetArea()
    {
        return _width * _height;            
    }
}

class Program
{
    static void Main()
    {
Blind kitchen = new Blind();

kitchen._width = 60;
kitchen._height = 48;
kitchen._color = "White";

double materialAmount = kitchen.GetArea();

Console.WriteLine($"The area of the blind is {materialAmount}");
 
    }
}
