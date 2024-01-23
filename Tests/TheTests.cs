using NUnit.Framework;

namespace Tests;

[TestFixture]
public class TheTests
{
    [Test]
    public void TheOneAndOnlyTest()
    {
        Assert.That(1 == 1, "Oh!");
    }
}

