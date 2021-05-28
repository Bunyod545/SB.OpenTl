// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c3db333)]
    public sealed class RequestUploadTheme : IRequest<OpenTl.Schema.IDocument>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputFile File {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputFile Thumb {get; set;}

       /// <summary>Binary representation for the 'FileName' property</summary>
       [SerializationOrder(3)]
       public byte[] FileNameAsBinary { get => _FileNameAsBinary; set { _FileName = Encoding.UTF8.GetString(value); _FileNameAsBinary = value; }}
       private byte[] _FileNameAsBinary;
       private string _FileName;
       public string FileName { get => _FileName; set { FileNameAsBinary = Encoding.UTF8.GetBytes(value); _FileName = value; }}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(4)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

    }
}
