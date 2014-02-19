using System;
using System.Collections.Generic;
using System.Linq;

namespace MarvelApiDataWrapper.Contracts
{
    public interface IConfiguration
    {
        string PublicKey { get; }
        string PrivateKey { get; }
        string MarvelApiEndpoint { get; }
        string MarvelApiVersion { get; }
    }
}
