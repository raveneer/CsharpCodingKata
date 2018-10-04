using System;
using NUnit.Framework;

public class Kata
{
    public static int CalculateTip(double amount, string rating)
    {
        var tip = (int)(Math.Round(double.Parse(rating), 0));
        if (tip >= 20)
        {
            return 4;
        }
        if (tip >= 15)
        {
            return 3;
        }
        if (tip >= 10)
        {
            return 2;
        }
        if (tip >= 5)
        {
            return 1;
        }
        return 0;
    }

    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.AreEqual(4, CalculateTip(20, "Excellent"));
        Assert.AreEqual(3, CalculateTip(26.95, "good"));
    }
}