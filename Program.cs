using System.Runtime.InteropServices.JavaScript;

namespace LongestCommonPrefixCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return null;
            else if (strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                string common = strs[0];
                foreach (string str in strs)
                {

                }
            }
            return string.Empty;
        }
    }
}
//