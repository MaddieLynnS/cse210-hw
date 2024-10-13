using System;

class Box
{
    public double _height;
    public double _width;
    public double _length;
    public string _unit;

    public string describe()
    {
        return $"Box with length {_length} and width {_width} and height {_height} using the {_unit} unit";
    }

    public double volume()
    {
        return _length * _width * _height;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Box myBox = new Box();
        myBox._height = 2;
        myBox._length = 7;
        myBox._width = 4;
        myBox._unit = "yard";

        Console.WriteLine(myBox.describe());
    }
}