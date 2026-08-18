using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.UnitOfTime;

/// <summary>
/// Identifies the unit used to express a duration, interval, or calendar period.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class UnitOfTime
{
    /// <summary>
    /// A .NET time tick, equal to 100 nanoseconds.
    /// </summary>
    public static readonly UnitOfTime Tick = new(nameof(Tick));
    /// <summary>
    /// One billionth of a second.
    /// </summary>
    public static readonly UnitOfTime Nanosecond = new(nameof(Nanosecond));
    /// <summary>
    /// One millionth of a second.
    /// </summary>
    public static readonly UnitOfTime Microsecond = new(nameof(Microsecond));
    /// <summary>
    /// One thousandth of a second.
    /// </summary>
    public static readonly UnitOfTime Millisecond = new(nameof(Millisecond));
    /// <summary>
    /// One second.
    /// </summary>
    public static readonly UnitOfTime Second = new(nameof(Second));
    /// <summary>
    /// One minute.
    /// </summary>
    public static readonly UnitOfTime Minute = new(nameof(Minute));
    /// <summary>
    /// One hour.
    /// </summary>
    public static readonly UnitOfTime Hour = new(nameof(Hour));
    /// <summary>
    /// One day.
    /// </summary>
    public static readonly UnitOfTime Day = new(nameof(Day));
    /// <summary>
    /// One week.
    /// </summary>
    public static readonly UnitOfTime Week = new(nameof(Week));
    /// <summary>
    /// One calendar month.
    /// </summary>
    public static readonly UnitOfTime Month = new(nameof(Month));
    /// <summary>
    /// One calendar quarter.
    /// </summary>
    public static readonly UnitOfTime Quarter = new(nameof(Quarter));
    /// <summary>
    /// One calendar year.
    /// </summary>
    public static readonly UnitOfTime Year = new(nameof(Year));
    /// <summary>
    /// Ten calendar years.
    /// </summary>
    public static readonly UnitOfTime Decade = new(nameof(Decade));
}
