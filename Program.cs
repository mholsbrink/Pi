using System;

namespace Pi
{
    /// <summary>
    /// https://www.wikihow.com/Calculate-Pi
    /// </summary>
    class Program
    {
        static void Main()
        {
            const int precision = 5;

            double pPower = Math.Pow(10, precision);
            double constant = 4 * pPower * pPower;
            double approximationOfPi = 0;
            double sign = -1;
            double divider = 1;
            double diff;
            double lastApproximationOfPi;

            do
            {
                lastApproximationOfPi = approximationOfPi;
                approximationOfPi += (constant / divider * (sign *= -1));
                divider += 2;
                diff = Math.Abs(lastApproximationOfPi - approximationOfPi);

                Console.WriteLine(diff);
            }
            while (diff >= pPower);             
            
            Console.WriteLine($"{approximationOfPi/(pPower * pPower):N5}; {Math.PI:N5}");
        }
    }
}