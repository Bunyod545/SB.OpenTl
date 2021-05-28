// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7ae43737)]
    public sealed class RequestInstallTheme : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Dark {get; set;}

       /// <summary>Binary representation for the 'Format' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public byte[] FormatAsBinary { get => _FormatAsBinary; set { _Format = Encoding.UTF8.GetString(value); _FormatAsBinary = value; }}
       private byte[] _FormatAsBinary;
       private string _Format;
       public string Format { get => _Format; set { FormatAsBinary = Encoding.UTF8.GetBytes(value); _Format = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IInputTheme Theme {get; set;}

    }
}
