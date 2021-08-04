﻿using System;

namespace Pi
{
    /// <summary>
    /// https://www.wikihow.com/Calculate-Pi
    /// </summary>
    class Program
    {
        static void Main()
        {
            const int constant = 4;

            var approximationOfPi = 0m;
            var sign = -1;
            var divider = 1m;

            decimal diff;
            decimal lastApproximationOfPi;

            do
            {
                lastApproximationOfPi = approximationOfPi;
                approximationOfPi += constant / divider * (sign *= -1);
                divider += 2;
                diff = Math.Abs(lastApproximationOfPi - approximationOfPi);

                Console.WriteLine(diff);
            }
            while (diff >= 0.000001m);

            Console.WriteLine($"{approximationOfPi:N5}; {Math.PI:N5}");
        }
    }
}