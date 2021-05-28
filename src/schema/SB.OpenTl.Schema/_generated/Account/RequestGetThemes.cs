// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x285946f8)]
    public sealed class RequestGetThemes : IRequest<OpenTl.Schema.Account.IThemes>
    {
       /// <summary>Binary representation for the 'Format' property</summary>
       [SerializationOrder(0)]
       public byte[] FormatAsBinary { get => _FormatAsBinary; set { _Format = Encoding.UTF8.GetString(value); _FormatAsBinary = value; }}
       private byte[] _FormatAsBinary;
       private string _Format;
       public string Format { get => _Format; set { FormatAsBinary = Encoding.UTF8.GetBytes(value); _Format = value; }}

       [SerializationOrder(1)]
       public int Hash {get; set;}

    }
}
