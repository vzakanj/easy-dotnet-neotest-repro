namespace Repro.Bar.Tests;

public class BarTests
{
    [Test]
    public async Task bar_passes()
    {
        await Assert.That(true).IsTrue();
    }
}
