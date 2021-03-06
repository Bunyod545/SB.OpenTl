// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6ca9c2e9)]
	public sealed class TPollAnswer : IPollAnswer
	{
       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(0)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

       [SerializationOrder(1)]
       public byte[] Option {get; set;}

	}
}
