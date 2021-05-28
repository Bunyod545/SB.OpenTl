// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICountryCode : IObject
    {
       BitArray Flags {get; set;}

       byte[] CountryCodeAsBinary {get; set;}
       string CountryCode {get; set;}

       OpenTl.Schema.TVector<string> Prefixes {get; set;}

       OpenTl.Schema.TVector<string> Patterns {get; set;}

    }
}
