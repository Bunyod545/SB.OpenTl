// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICountry : IObject
    {
       BitArray Flags {get; set;}

       bool Hidden {get; set;}

       byte[] Iso2AsBinary {get; set;}
       string Iso2 {get; set;}

       byte[] DefaultNameAsBinary {get; set;}
       string DefaultName {get; set;}

       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.Help.ICountryCode> CountryCodes {get; set;}

    }
}
