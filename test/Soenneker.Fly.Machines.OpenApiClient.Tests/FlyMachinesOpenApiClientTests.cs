using Soenneker.Tests.HostedUnit;

namespace Soenneker.Fly.Machines.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FlyMachinesOpenApiClientTests : HostedUnitTest
{
    public FlyMachinesOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
