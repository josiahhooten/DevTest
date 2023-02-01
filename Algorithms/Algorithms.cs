using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
            {
                throw new Exception("please provide a number greater than 0!");
            }

            if (n == 1) { return 1; };

            // Recursive call to get factoral
            return (n * GetFactorial(n - 1));
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items != null)
            {
                if (items.Length == 1)
                {
                    return items[0];
                }

                string retString = string.Empty;

                for (int i = 0; i < items.Length - 1; i++)
                {
                    retString += $"{items[i]}, ";
                }

                retString = retString.Substring(0, retString.LastIndexOf(',')) + $" and {items[items.Length - 1]}";
                return retString;
            } else
            {
                return string.Empty;
            }

        }
    }
}