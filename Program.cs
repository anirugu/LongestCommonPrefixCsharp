using System;
using System.Linq;

namespace LongestCommonPrefixCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var minLength = strs.Min(x => x.Length);
            // Maximum length of common prefix will be minLength;
            for(int i = 0; i < minLength; i++)
            {

            }
            return string.Empty;
        }
    }
}
