using AdventOfCode;

namespace AdventOfCodeTests;

public class Day2Tests
{
    [Test]
    public void CorrectResultPart1Test()
    {
        var expected = 14375;
        var actual = Day2.TotalPointsPart1("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/Day2_Input.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void BlankSpacesPart1Test()
    {
        var expected = 97;
        var actual = Day2.TotalPointsPart1("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/BlankSpacesTest.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void CorrectResultPart2Test()
    {
        var expected = 10274;
        var actual = Day2.TotalPointsPart2("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/Day2_Input.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void BlankSpacesPart2Test()
    {
        var expected = 59;
        var actual = Day2.TotalPointsPart2("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day2/BlankSpacesTest.txt");
        Assert.That(actual, Is.EqualTo(expected));
    }
}