// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x35553762)]
	public sealed class TTextAnchor : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(1)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

	}
}
