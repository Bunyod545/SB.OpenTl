// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc3878e23)]
	public sealed class TCountry : ICountry
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Hidden {get; set;}

       /// <summary>Binary representation for the 'Iso2' property</summary>
       [SerializationOrder(2)]
       public byte[] Iso2AsBinary { get => _Iso2AsBinary; set { _Iso2 = Encoding.UTF8.GetString(value); _Iso2AsBinary = value; }}
       private byte[] _Iso2AsBinary;
       private string _Iso2;
       public string Iso2 { get => _Iso2; set { Iso2AsBinary = Encoding.UTF8.GetBytes(value); _Iso2 = value; }}

       /// <summary>Binary representation for the 'DefaultName' property</summary>
       [SerializationOrder(3)]
       public byte[] DefaultNameAsBinary { get => _DefaultNameAsBinary; set { _DefaultName = Encoding.UTF8.GetString(value); _DefaultNameAsBinary = value; }}
       private byte[] _DefaultNameAsBinary;
       private string _DefaultName;
       public string DefaultName { get => _DefaultName; set { DefaultNameAsBinary = Encoding.UTF8.GetBytes(value); _DefaultName = value; }}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.Help.ICountryCode> CountryCodes {get; set;}

	}
}
