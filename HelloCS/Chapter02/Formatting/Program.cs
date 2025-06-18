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
        }
    }
}
