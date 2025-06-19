using System.Globalization;

namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-us");

            int numberOfBalls = 10;
            decimal pricePerBall = 0.10M;

            Console.WriteLine(
                format: "{0} balls costs {1:C}",
                arg0: numberOfBalls,
                arg1: pricePerBall * numberOfBalls);


            // is the same as this: string formatted = string.Format( "{0} balls cost {1:C}", numberOfBalls, pricePerBall * numberOfBalls );
            string formatted = string.Format(
                format: "{0} balls cost {1:C}",
                arg0: numberOfBalls,
                arg1: pricePerBall * numberOfBalls
                );


            string grapeText = "Grapes";
            int grapesCount = 1234;
            string orangeText = "Oranges";
            int orangesCount = 56789;
            int price = 123456;

            Console.WriteLine();

            Console.WriteLine(format: "{0, -10} {1,6}", arg0: "Name", arg1: "Count");// Here we're defining the index and allignment for data {0:.} meaning the index and what comes next is the formatting
            Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: grapeText, arg1: grapesCount);
            Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: orangeText, arg1: orangesCount);

            Console.WriteLine("{0:000.0}", 10); // This will output 010.0 and so on for formating
            Console.WriteLine("{0:###.###}", 10); // will output 10, or nothing

            //Separator (dot and coma)
            Console.WriteLine("{0:000,00}", orangesCount);// will output 56,789
            Console.WriteLine("{0:000.00}", orangesCount);// will output 56.789

            //Percentage
            Console.WriteLine("{0:0%}", orangesCount);

            // We can also also use standard number formating, like so:
            // Currency
            Console.WriteLine("The price is: {0:C2}", price); // will output The price is: $123,456.00
            Console.WriteLine("The price is: {0:C3}", price); // will output The price is: $123,456.000 and so on

            //Number
            Console.WriteLine("The value is: {0:N2}", price); // The value is: 123,456.00, with no sign or grouping characters

            DateTime date = new(2000, 10, 10);
            // Date part separator
            Console.WriteLine("The date is {0:MM*dd*yyyy}", date); // We can also change the way dates are displayed

            // And so many more, I'll leave the book's recomendation link to future recolection https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        }
    }
}
