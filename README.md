[![](https://img.shields.io/nuget/v/soenneker.enums.unitoftime.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.unitoftime/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.unitoftime/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.unitoftime/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.unitoftime.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.unitoftime/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.unitoftime/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.unitoftime/actions/workflows/codeql.yml)

# Soenneker.Enums.UnitOfTime

A string-backed enum-value type for carrying a duration or calendar-period unit through application and API contracts.

## Install

```bash
dotnet add package Soenneker.Enums.UnitOfTime
```

## Usage

```csharp
using Soenneker.Enums.UnitOfTime;

UnitOfTime unit = UnitOfTime.Minute;
string wireValue = unit.Value; // "Minute"

if (UnitOfTime.TryFromValue(input, out UnitOfTime? parsed))
{
    unit = parsed;
}
```

Available values:

- Subsecond: `Tick` (100 nanoseconds), `Nanosecond`, `Microsecond`, `Millisecond`
- Clock units: `Second`, `Minute`, `Hour`
- Larger periods: `Day`, `Week`, `Month`, `Quarter`, `Year`, `Decade`

`System.Text.Json` serializes the type as the shown string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` when parsing configuration or requests. `FromName` and `TryFromName` are also generated.

This package identifies a unit; it does not convert values, calculate a duration, or apply calendar arithmetic. Months, quarters, years, and decades vary by reference date, while a calendar day can differ from 24 elapsed hours across time-zone transitions. The consuming API must state whether `Day` and `Week` mean fixed elapsed durations or calendar periods, define its time zone, and use a numeric type with sufficient range and precision.
