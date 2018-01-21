using Microsoft.AspNetCore.Mvc;
using System;

namespace LemonWayAPI.Controllers
{
    [Route("fibonacci")]
    public class FibonacciController
    {
        /// <summary>The golden ratio of the fibonacci sequence.</summary>
        private readonly double goldenRatio = (1 + Math.Sqrt(5)) / 2;

        //GET /fibonacci/{n}
        [HttpGet("{n}")]
        public double Fibonacci1(int n)
        {
            double result = -1;
            if (n >= 1 || n <= 100)
            {
                result = GetFibonacci(n);
            }

            return result;
        }

        /// <summary>
        /// Gets the number of the fibonacci sequence.
        /// </summary>
        /// <param name="n">The order number.</param>
        /// <returns>The number of the fibonacci sequence.</returns>
        private double GetFibonacci(int n)
        {
            double result = (Math.Pow(goldenRatio, n) - (Math.Pow(-goldenRatio, -n))) / (2 * goldenRatio - 1);
            return (double)Math.Round(result);
        }
    }
}
