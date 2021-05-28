// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x812c2ae6)]
    public sealed class RequestGetStatsURL : IRequest<OpenTl.Schema.IStatsURL>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Dark {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       /// <summary>Binary representation for the 'Params' property</summary>
       [SerializationOrder(3)]
       public byte[] ParamsAsBinary { get => _ParamsAsBinary; set { _Params = Encoding.UTF8.GetString(value); _ParamsAsBinary = value; }}
       private byte[] _ParamsAsBinary;
       private string _Params;
       public string Params { get => _Params; set { ParamsAsBinary = Encoding.UTF8.GetBytes(value); _Params = value; }}

    }
}
