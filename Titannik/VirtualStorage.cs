namespace Titannik;

public class VirtualStorage : IStorable
{
    private int Value { get; set; } = 35;
    
    public int GetValue()
    {
        return Value;
    }

    public void SetValue(int value)
    {
        Value = value;
    }
}