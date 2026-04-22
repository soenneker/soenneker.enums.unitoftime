using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.UnitOfTime.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class UnitOfTimeTests : HostedUnitTest
{
    public UnitOfTimeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
