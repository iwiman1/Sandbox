using Day1NS;

namespace Day1Tests;

public class Day1Tests
{
    [Test]
    public void CorrectResultTest()
    {
        var expectedResult = 72718;
        var result = Day1.Day1Script("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/Day1_Input.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void BlankSpacesTest()
    {
        var expectedResult = 21000;
        var result = Day1.Day1Script("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/BlankSpacesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void InitialAndLastBlankLinesTest()
    {
        var expectedResult = 21000;
        var result = Day1.Day1Script("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/InitialAndLastBlankLinesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}