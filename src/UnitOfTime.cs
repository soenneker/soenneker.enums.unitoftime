using Ardalis.SmartEnum;

namespace Soenneker.Enums.UnitOfTime;

/// <summary>
/// An enumerator for describing an interval of time
/// </summary>
public sealed class UnitOfTime : SmartEnum<UnitOfTime>
{
    public static readonly UnitOfTime Tick = new(nameof(Tick), 0);
    public static readonly UnitOfTime Nanosecond = new(nameof(Nanosecond), 1);
    public static readonly UnitOfTime Microsecond = new(nameof(Microsecond), 2);
    public static readonly UnitOfTime Millisecond = new(nameof(Millisecond), 3);
    public static readonly UnitOfTime Second = new(nameof(Second), 4);
    public static readonly UnitOfTime Minute = new(nameof(Minute), 5);
    public static readonly UnitOfTime Hour = new(nameof(Hour), 6);
    public static readonly UnitOfTime Day = new(nameof(Day), 7);
    public static readonly UnitOfTime Week = new(nameof(Week), 8);
    public static readonly UnitOfTime Month = new(nameof(Month), 9);
    public static readonly UnitOfTime Quarter = new(nameof(Quarter), 10);
    public static readonly UnitOfTime Year = new(nameof(Year), 11);
    public static readonly UnitOfTime Decade = new(nameof(Decade), 12);

    private UnitOfTime(string name, int value) : base(name, value)
    {
    }
}