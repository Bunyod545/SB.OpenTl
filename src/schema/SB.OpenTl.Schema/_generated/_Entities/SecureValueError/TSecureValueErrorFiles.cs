// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x666220e9)]
	public sealed class TSecureValueErrorFiles : ISecureValueError
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ISecureValueType Type {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<byte[]> FileHash {get; set;}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(2)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

	}
}
