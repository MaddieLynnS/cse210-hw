using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello itsa me!");
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3, 2);

        Console.WriteLine(fraction.GetBottom());
        
        Console.WriteLine(fraction1.GetTop());
        
        fraction2.SetBottom(7);
        Console.WriteLine(fraction2.GetBottom());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}