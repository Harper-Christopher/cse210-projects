using System.Diagnostics.Tracing;

public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom() 
    {
        return _bottom;
    }

    public void SetBottom (int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        double decimalFraction = (double)_top / (double)_bottom;
        return decimalFraction;
    }
}

