using System.Diagnostics.CodeAnalysis;

namespace Day2NS;

public class Day2
{
    private int GetPointsForMyChoice(string myChoice)
    {
        switch (myChoice)
        {
            case "X": return 1;
            case "Y": return 2;
            case "Z": return 3;
            default: throw new ArgumentException("Not a valid choice");
        }
    }

    private int GetPointsForResult(string opponentChoice, string myChoice)
    {
        switch (myChoice)
        {
            case "X":
                switch (opponentChoice)
                {
                    case "A": return 3;
                    case "B": return 0;
                    case "C": return 6;
                    default: throw new ArgumentException("Not a valid opponent choice");
                }
            case "Y":
                switch (opponentChoice)
                {
                    case "A": return 6;
                    case "B": return 3;
                    case "C": return 0;
                    default: throw new ArgumentException("Not a valid opponent choice");
                }
            case "Z":
                switch (opponentChoice)
                {
                    case "A": return 0;
                    case "B": return 6;
                    case "C": return 3;
                    default: throw new ArgumentException("Not a valid opponent choice");
                }
            default: throw new ArgumentException("Not a valid choice");
        }
    }

    public int MainMethod(string filePath)
    {
        // Initialize StreamReader.
        using StreamReader sr = new(filePath);

        string? rawLine;

        var totalPoints = 0;

        // Iterate over the input lines.
        while ((rawLine = sr.ReadLine()) != null)
        {
            // Trim to get rid of unwanted blank spaces.
            var line = rawLine.Trim();

            var opponentChoice = line.Split(' ')[1];
            var myChoice = line.Split(' ')[2];

            var pointsForMyChoice = GetPointsForMyChoice(myChoice);

            var pointsForResult = GetPointsForResult(opponentChoice, myChoice);

            var roundPoints = pointsForMyChoice + pointsForResult;

            totalPoints =+ roundPoints;
        }

        return totalPoints;
    }
}