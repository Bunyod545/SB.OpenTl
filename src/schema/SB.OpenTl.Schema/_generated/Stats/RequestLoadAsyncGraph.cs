// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x621d5fa0)]
    public sealed class RequestLoadAsyncGraph : IRequest<OpenTl.Schema.IStatsGraph>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Token' property</summary>
       [SerializationOrder(1)]
       public byte[] TokenAsBinary { get => _TokenAsBinary; set { _Token = Encoding.UTF8.GetString(value); _TokenAsBinary = value; }}
       private byte[] _TokenAsBinary;
       private string _Token;
       public string Token { get => _Token; set { TokenAsBinary = Encoding.UTF8.GetBytes(value); _Token = value; }}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public long X {get; set;}

    }
}
