namespace Day1NS;

public class Day1
{
    public static int MaxCalories(string filePath)
    {
        // Initialize needed variables.
        var maxCalories = 0;
        var currentTotal = 0;

        // Initialize StreamReader.
        using StreamReader sr = new StreamReader(filePath);

        string? rawLine;

        // Iterate over the input lines.
        while ((rawLine = sr.ReadLine()) != null)
        {
            // Trim to get rid of unwanted blank spaces.
            var line = rawLine.Trim();

            // If there's a blank line, the current elf has finished.
            if (line == "")
            {
                // If the current calories are greater than the max calories, then we update the max calories.
                if (currentTotal > maxCalories)
                {
                    maxCalories = currentTotal;
                }
                // We reset the current calories and skip to the next iteration.
                currentTotal = 0;
                continue;
            }

            // Add each line to the current total.
            currentTotal += int.Parse(line);
        }

        // To catch last elf.
        if (currentTotal > maxCalories)
        {
            maxCalories = currentTotal;
        }

        return maxCalories;
    }

    public static int SumOfTop3(string filePath)
    {
        // Initialize needed variables.
        var maxCalories1 = 0;
        var maxCalories2 = 0;
        var maxCalories3 = 0;
        var currentTotal = 0;

        // Initialize StreamReader.
        using StreamReader sr = new StreamReader(filePath);

        string? rawLine;

        // Iterate over the input lines.
        while ((rawLine = sr.ReadLine()) != null)
        {
            // Trim to get rid of unwanted blank spaces.
            var line = rawLine.Trim();

            // If there's a blank line, the current elf has finished.
            if (line == "")
            {
                // We check if this elf is one of the top 3 calorie holder. Then we reset the current calories and skip to the next iteration.
                if (currentTotal > maxCalories1)
                {
                    maxCalories3 = maxCalories2;
                    maxCalories2 = maxCalories1;
                    maxCalories1 = currentTotal;
                    currentTotal = 0;
                    continue;
                }
                if (currentTotal > maxCalories2)
                {
                    maxCalories3 = maxCalories2;
                    maxCalories2 = currentTotal;
                    currentTotal = 0;
                    continue;
                }
                if (currentTotal > maxCalories3)
                {
                    maxCalories3 = currentTotal;
                    currentTotal = 0;
                    continue;
                }
                currentTotal = 0;
                continue;
            }

            // Add each line to the current total.
            currentTotal += int.Parse(line);
        }

        // To catch last elf.
        if (currentTotal > maxCalories1)
        {
            maxCalories3 = maxCalories2;
            maxCalories2 = maxCalories1;
            maxCalories1 = currentTotal;
            currentTotal = 0;
        }
        if (currentTotal > maxCalories2)
        {
            maxCalories3 = maxCalories2;
            maxCalories2 = currentTotal;
            currentTotal = 0;
        }
        if (currentTotal > maxCalories3)
        {
            maxCalories3 = currentTotal;
            currentTotal = 0;
        }

        return (maxCalories1 + maxCalories2 + maxCalories3);
    }
}