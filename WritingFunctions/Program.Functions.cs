

partial class Program
{
    // number and size are parameters of the method
    static void MultiplyTable(byte number, byte size = 12) // is a static method because it will be called by the static method <Main>$
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            Console.WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" or "NO" => 0.25M, // Denmark, Norway
            "GB" or "FR" => 0.2M, // UK, France
            "HU" => 0.27M, // Hungary
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M, // California
            _ => 0.06M // Most other states.
        };
        
        return rate * amount;
    }

    static string CardinalToOrdinal (uint number)
    {
        uint lastTwoDigits = number % 100;
        switch (lastTwoDigits) //  switch statement
        {
            case 11:
            case 12:
            case 13:
                return $"{number}th"; // Special cases for 11th, 12th, and 13th
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch // switch expression
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 150; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    static int Factorial(int number)
    {
        if(number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be non-negative.");
        } else if (number == 0)
        {
            return 1;
        } else
        {
            return number * Factorial(number - 1);
        }
    }

    static void RunFactorial()
    {
        for (int i = 1; i <= 15; i++)
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
    }
}
