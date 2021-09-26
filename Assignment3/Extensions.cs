using System;
using System.Text.RegularExpressions; 
using System.Linq;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri url) => url.Scheme == "https";

        public static int WordCount(this string s)
        {
            var pattern = @"(\s|^)(?<word>\p{L}+)(?=\s|$)";
            var matches = Regex.Matches(s, pattern);
            var res = 0;
            foreach(Match match in matches) 
            {
                if (match.Groups["word"].Value.Length > 0)  {
                    res++;
                }
            }

            return res;
        }
    }
}
