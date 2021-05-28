// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8ea464b6)]
	public sealed class TStatsGraph : IStatsGraph
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDataJSON Json {get; set;}

       /// <summary>Binary representation for the 'ZoomToken' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] ZoomTokenAsBinary { get => _ZoomTokenAsBinary; set { _ZoomToken = Encoding.UTF8.GetString(value); _ZoomTokenAsBinary = value; }}
       private byte[] _ZoomTokenAsBinary;
       private string _ZoomToken;
       public string ZoomToken { get => _ZoomToken; set { ZoomTokenAsBinary = Encoding.UTF8.GetBytes(value); _ZoomToken = value; }}

	}
}
