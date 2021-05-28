// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4203c5ef)]
	public sealed class TCountryCode : ICountryCode
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'CountryCode' property</summary>
       [SerializationOrder(1)]
       public byte[] CountryCodeAsBinary { get => _CountryCodeAsBinary; set { _CountryCode = Encoding.UTF8.GetString(value); _CountryCodeAsBinary = value; }}
       private byte[] _CountryCodeAsBinary;
       private string _CountryCode;
       public string CountryCode { get => _CountryCode; set { CountryCodeAsBinary = Encoding.UTF8.GetBytes(value); _CountryCode = value; }}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<string> Prefixes {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<string> Patterns {get; set;}

	}
}
