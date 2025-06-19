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
                arg1: pricePerBall * numberOfBalls );
      

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

        Console.WriteLine();

        Console.WriteLine(format: "{0, -10} {1,6}", arg0: "Name", arg1: "Count");// Here we're defining the index and allignment for data {0:.} meaning the index and what comes next is the formatting
        }
    }
}
