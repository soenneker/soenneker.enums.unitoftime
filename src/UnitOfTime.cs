using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.UnitOfTime;

/// <summary>
/// An enumerator for describing an interval of time
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public sealed partial class UnitOfTime
{
    public static readonly UnitOfTime Tick = new(nameof(Tick));
    public static readonly UnitOfTime Nanosecond = new(nameof(Nanosecond));
    public static readonly UnitOfTime Microsecond = new(nameof(Microsecond));
    public static readonly UnitOfTime Millisecond = new(nameof(Millisecond));
    public static readonly UnitOfTime Second = new(nameof(Second));
    public static readonly UnitOfTime Minute = new(nameof(Minute));
    public static readonly UnitOfTime Hour = new(nameof(Hour));
    public static readonly UnitOfTime Day = new(nameof(Day));
    public static readonly UnitOfTime Week = new(nameof(Week));
    public static readonly UnitOfTime Month = new(nameof(Month));
    public static readonly UnitOfTime Quarter = new(nameof(Quarter));
    public static readonly UnitOfTime Year = new(nameof(Year));
    public static readonly UnitOfTime Decade = new(nameof(Decade));
}