// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbad07584)]
	public sealed class TInputDocumentFileLocation : IInputFileLocation
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public byte[] FileReference {get; set;}

       /// <summary>Binary representation for the 'ThumbSize' property</summary>
       [SerializationOrder(3)]
       public byte[] ThumbSizeAsBinary { get => _ThumbSizeAsBinary; set { _ThumbSize = Encoding.UTF8.GetString(value); _ThumbSizeAsBinary = value; }}
       private byte[] _ThumbSizeAsBinary;
       private string _ThumbSize;
       public string ThumbSize { get => _ThumbSize; set { ThumbSizeAsBinary = Encoding.UTF8.GetBytes(value); _ThumbSize = value; }}

	}
}
