
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
                var minLength = strs.Min(x => x.Length);
                string common = string.Empty;
                //for(int i =0;i<minLength;i++)
                //{

                //}
            }
            return string.Empty;
        }
    }
}
//