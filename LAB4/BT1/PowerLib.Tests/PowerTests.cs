using NUnit.Framework;

[TestFixture]
public class PowerTests
{
    [Test]
    public void Power_NEquals0_Return1()
    {
        Assert.That(PowerHelper.Power(5, 0), Is.EqualTo(1));
    }

    [Test]
    public void Power_PositiveExponent()
    {
        Assert.That(PowerHelper.Power(2, 3), Is.EqualTo(8));
    }

    [Test]
    public void Power_NegativeExponent()
    {
        Assert.That(PowerHelper.Power(2, -2), Is.EqualTo(0.25).Within(0.0001));
    }
}
