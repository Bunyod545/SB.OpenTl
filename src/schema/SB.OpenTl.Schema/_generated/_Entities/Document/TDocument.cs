// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1e87342b)]
	public sealed class TDocument : IDocument
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long Id {get; set;}

       [SerializationOrder(2)]
       public long AccessHash {get; set;}

       [SerializationOrder(3)]
       public byte[] FileReference {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(5)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(6)]
       public int Size {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhotoSize> Thumbs {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IVideoSize> VideoThumbs {get; set;}

       [SerializationOrder(9)]
       public int DcId {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocumentAttribute> Attributes {get; set;}

	}
}
