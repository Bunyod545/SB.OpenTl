// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb71e767a)]
	public sealed class TJsonString : IJSONValue
	{
       /// <summary>Binary representation for the 'Value' property</summary>
       [SerializationOrder(0)]
       public byte[] ValueAsBinary { get => _ValueAsBinary; set { _Value = Encoding.UTF8.GetString(value); _ValueAsBinary = value; }}
       private byte[] _ValueAsBinary;
       private string _Value;
       public string Value { get => _Value; set { ValueAsBinary = Encoding.UTF8.GetBytes(value); _Value = value; }}

	}
}
