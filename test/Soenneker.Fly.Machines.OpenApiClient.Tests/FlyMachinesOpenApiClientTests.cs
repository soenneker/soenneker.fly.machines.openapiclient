using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Fly.Machines.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class FlyMachinesOpenApiClientTests : FixturedUnitTest
{
    public FlyMachinesOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
