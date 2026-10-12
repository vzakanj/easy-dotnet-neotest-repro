namespace Repro.Foo.Tests;

public class FooTests
{
    [Test]
    public async Task foo_passes()
    {
        await Assert.That(true).IsTrue();
    }
}
