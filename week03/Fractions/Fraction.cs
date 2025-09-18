class Fraction
{
    private int _numerator;
    private int _demoninator;

    // constructors

    public Fraction()
    {
        _numerator = 1;
        _demoninator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _demoninator = 1;
    }
    public Fraction(int numerator, int demoninator)
    {
        _numerator = numerator;
        _demoninator = demoninator;
    }

    // getters and setters

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDemoninator()
    {
        return _demoninator;
    }

    public void SetNumerator(int newNum)
    {
        _numerator = newNum;
    }

    public void SetDemoninator(int newDem)
    {
        _demoninator = newDem;
    }

    // member methods
    public string GetFractionString()
    {
        return $"{_numerator}/{_demoninator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _demoninator;
    }
}