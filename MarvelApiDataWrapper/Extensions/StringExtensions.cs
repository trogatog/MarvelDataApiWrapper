using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.Constants;

namespace MarvelApiDataWrapper.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static string AppendUrlPath(this string input, string path)
        {
            return string.Format(UrlFormatters.URL_APPEND, input, path);
        }
    }
}
