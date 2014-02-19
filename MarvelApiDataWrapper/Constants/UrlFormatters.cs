using System;
using System.Collections.Generic;
using System.Linq;

namespace MarvelApiDataWrapper.Constants
{
    public static class UrlFormatters
    {
        public const string REST_ENDPOINT_FORMATTER = "{0}/v{1}/public";
        public const string URL_APPEND = "{0}/{1}";
        public const string URL_PARAMETERS = "{0}?ts={1}&apikey={2}&hash={3}";
    }
}
