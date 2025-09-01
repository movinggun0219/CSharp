using System;
using System.Text;

namespace MyExtension
{
    public static class ExClass
    {
        public static string ToChangeCase(this String str)
        {
            var sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    sb.Append((char)('a' + ch - 'A'));
                }
                else if (ch >= 'a' && ch <= 'z')
                    sb.Append((char)('A' + ch - 'a'));
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }
        public static bool Found(this String str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0;
        }
    }
}