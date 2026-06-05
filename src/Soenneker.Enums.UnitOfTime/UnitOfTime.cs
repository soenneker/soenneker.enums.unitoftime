using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.UnitOfTime;

/// <summary>
/// An enumerator for describing an interval of time
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class UnitOfTime
{
    /// <summary>
    /// The tick.
    /// </summary>
    public static readonly UnitOfTime Tick = new(nameof(Tick));
    /// <summary>
    /// The nanosecond.
    /// </summary>
    public static readonly UnitOfTime Nanosecond = new(nameof(Nanosecond));
    /// <summary>
    /// The microsecond.
    /// </summary>
    public static readonly UnitOfTime Microsecond = new(nameof(Microsecond));
    /// <summary>
    /// The millisecond.
    /// </summary>
    public static readonly UnitOfTime Millisecond = new(nameof(Millisecond));
    /// <summary>
    /// The second.
    /// </summary>
    public static readonly UnitOfTime Second = new(nameof(Second));
    /// <summary>
    /// The minute.
    /// </summary>
    public static readonly UnitOfTime Minute = new(nameof(Minute));
    /// <summary>
    /// The hour.
    /// </summary>
    public static readonly UnitOfTime Hour = new(nameof(Hour));
    /// <summary>
    /// The day.
    /// </summary>
    public static readonly UnitOfTime Day = new(nameof(Day));
    /// <summary>
    /// The week.
    /// </summary>
    public static readonly UnitOfTime Week = new(nameof(Week));
    /// <summary>
    /// The month.
    /// </summary>
    public static readonly UnitOfTime Month = new(nameof(Month));
    /// <summary>
    /// The quarter.
    /// </summary>
    public static readonly UnitOfTime Quarter = new(nameof(Quarter));
    /// <summary>
    /// The year.
    /// </summary>
    public static readonly UnitOfTime Year = new(nameof(Year));
    /// <summary>
    /// The decade.
    /// </summary>
    public static readonly UnitOfTime Decade = new(nameof(Decade));
}