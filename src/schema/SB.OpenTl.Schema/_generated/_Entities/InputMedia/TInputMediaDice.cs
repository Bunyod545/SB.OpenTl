// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe66fbf7b)]
	public sealed class TInputMediaDice : IInputMedia
	{
       /// <summary>Binary representation for the 'Emoticon' property</summary>
       [SerializationOrder(0)]
       public byte[] EmoticonAsBinary { get => _EmoticonAsBinary; set { _Emoticon = Encoding.UTF8.GetString(value); _EmoticonAsBinary = value; }}
       private byte[] _EmoticonAsBinary;
       private string _Emoticon;
       public string Emoticon { get => _Emoticon; set { EmoticonAsBinary = Encoding.UTF8.GetBytes(value); _Emoticon = value; }}

	}
}
