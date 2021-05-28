// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1ccb966a)]
	public sealed class TTextPhone : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       /// <summary>Binary representation for the 'Phone' property</summary>
       [SerializationOrder(1)]
       public byte[] PhoneAsBinary { get => _PhoneAsBinary; set { _Phone = Encoding.UTF8.GetString(value); _PhoneAsBinary = value; }}
       private byte[] _PhoneAsBinary;
       private string _Phone;
       public string Phone { get => _Phone; set { PhoneAsBinary = Encoding.UTF8.GetBytes(value); _Phone = value; }}

	}
}
