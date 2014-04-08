using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "a*";
            string input = "abaabb";

            Match m = Regex.Match(input, pattern);
            while (m.Success)
            {
                Console.WriteLine("'{0}' found at index {1}.",
                                  m.Value, m.Index);
                m = m.NextMatch();
            }
        }
    }
}
