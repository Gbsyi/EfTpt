namespace EfTpt.Ef.Types;

public class Speed
{
    public int Value { get; }

    public Speed(int value)
    {
        if (value < 0) 
            throw new ArgumentException("Speed value can't be negative", nameof(value));
        Value = value;
    }
}