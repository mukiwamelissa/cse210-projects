using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    }

    using System;

internal class Fraction
{
    // Attributes
    private int top;
    private int bottom;

    // Default constructor
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor with parameters
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        this.top = top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    // Returns fraction as a string
    public string GetFractionString()
    {
        return top + "/" + bottom;
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}

}
