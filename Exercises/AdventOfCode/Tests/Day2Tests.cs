using AdventOfCode;

namespace AdventOfCodeTests;

public class Day2Tests
{
    [Test]
    public void CorrectResultTest()
    {
        var expected = 14375;
        var actual = Day2.TotalPoints("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/Day2_Input.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void BlankSpacesTest()
    {
        var expected = 97;
        var actual = Day2.TotalPoints("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/BlankSpacesTest.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }


}