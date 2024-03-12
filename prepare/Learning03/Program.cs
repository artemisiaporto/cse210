using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction stFraction = new Fraction();
        //stFraction.GetTop();
        //stFraction.GetBottom();
        Console.WriteLine(stFraction.GetFractionString());
        Console.WriteLine(stFraction.GetDecimalValue());

        Fraction ndFraction = new Fraction(5);
        //ndFraction.SetTop(6);
        //ndFraction.GetTop();
        //ndFraction.GetBottom();
        Console.WriteLine(ndFraction.GetFractionString());
        Console.WriteLine(ndFraction.GetDecimalValue());

        Fraction rdFraction = new Fraction(3,4);
        //rdFraction.SetTop(6);
        //rdFraction.GetTop();
        //rdFraction.SetBottom(7);
        //rdFraction.GetBottom();
        Console.WriteLine(rdFraction.GetFractionString());
        Console.WriteLine(rdFraction.GetDecimalValue());

        Fraction thFraction = new Fraction(1,3);
        //rdFraction.SetTop(6);
        //rdFraction.GetTop();
        //rdFraction.SetBottom(7);
        //rdFraction.GetBottom();
        Console.WriteLine(thFraction.GetFractionString());
        Console.WriteLine(thFraction.GetDecimalValue());
    }
}