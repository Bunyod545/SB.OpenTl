// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdd853661)]
    public sealed class RequestUploadWallPaper : IRequest<OpenTl.Schema.IWallPaper>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputFile File {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(1)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.IWallPaperSettings Settings {get; set;}

    }
}
