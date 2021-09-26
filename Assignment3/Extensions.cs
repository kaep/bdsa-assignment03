using System;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri url) => url.Scheme == "https";
    }
}
