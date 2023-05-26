using Day1NS;

namespace Day1Tests;

public class Day1Tests
{
    [Test]
    public void CorrectResultPart1Test()
    {
        var expectedResult = 72718;
        var result = Day1.MaxCalories("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/Day1_Input.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void BlankSpacesPart1Test()
    {
        var expectedResult = 21000;
        var result = Day1.MaxCalories("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/BlankSpacesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void InitialAndLastBlankLinesPart1Test()
    {
        var expectedResult = 21000;
        var result = Day1.MaxCalories("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/InitialAndLastBlankLinesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void MaxValueIsInTheFirstLinePart1Test()
    {
        var expectedResult = 100000;
        var result = Day1.MaxCalories("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/MaxValueInFirstLineTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void MaxValueIsInTheLastLinePart1Test()
    {
        var expectedResult = 100000;
        var result = Day1.MaxCalories("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/MaxValueInLastLineTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void CorrectResultPart2Test()
    {
        var expectedResultPart2 = 213089;
        var resultPart2 = Day1.SumOfTop3("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/Day1_Input.txt");
        Assert.That(resultPart2, Is.EqualTo(expectedResultPart2));
    }

    [Test]
    public void BlankSpacesPart2Test()
    {
        var expectedResult = 41000;
        var result = Day1.SumOfTop3("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/BlankSpacesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void InitialAndLastBlankLinesPart2Test()
    {
        var expectedResult = 41000;
        var result = Day1.SumOfTop3("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/InitialAndLastBlankLinesTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void MaxValueIsInTheFirstLinePart2Test()
    {
        var expectedResult = 136000;
        var result = Day1.SumOfTop3("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/MaxValueInFirstLineTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void MaxValueIsInTheLastLinePart2Test()
    {
        var expectedResult = 136000;
        var result = Day1.SumOfTop3("F:/Dev/Ignacio/Exercises/AdventOfCode/Tests/resources/Day1/MaxValueInLastLineTest.txt");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}