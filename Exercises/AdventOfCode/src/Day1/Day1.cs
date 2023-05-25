namespace Day1NS;

public class Day1
{
    public static int Day1Script(string filePath)
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

            // If there's a blank line, the elf has chenged, so we reset the current calorie counter, we skip this iteration and move on with the next elf.
            if (line == "")
            {
                currentTotal = 0;
                continue;
            }

            // Add each line to the current total.
            currentTotal += int.Parse(line);
            
            // If the current calories are greater than the max calories, then we update the max calories.
            if (currentTotal > maxCalories)
            {
                maxCalories = currentTotal;
            }
        }

        return maxCalories;
    }
}