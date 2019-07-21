using System;
using System.Collections.Generic;

namespace github_aspnet.Models
{
    public static class Fibonacci
    {
        /// <summary>
        /// Return the Fibonacci sequence.
        /// </summary>
        /// <param name="level">Level of the sequence that want to return.</param>
        /// <returns></returns>
        public static List<int> CalculateFibonacci(int level)
        {
            if (level > 999)
                throw new Exception("More than that may be dangerous my friend...");

            List<int> fibonacciSequence = new List<int>(level);
            int currentLevel = 0, currentValue = 0;

            if (level > 0)
            {
                do
                {
                    if (fibonacciSequence.Count == 0)
                    {
                        fibonacciSequence.Add(currentValue);
                        currentValue++;
                    }
                    else if (fibonacciSequence.Count < 3)
                    {
                        fibonacciSequence.Add(currentValue);
                    }
                    else
                    {
                        currentValue = fibonacciSequence[currentLevel - 1] + fibonacciSequence[currentLevel - 2];
                        fibonacciSequence.Add(currentValue);
                    }
                    currentLevel++;
                }
                while (currentLevel < level);
            }
            return fibonacciSequence;
        }
    }
}