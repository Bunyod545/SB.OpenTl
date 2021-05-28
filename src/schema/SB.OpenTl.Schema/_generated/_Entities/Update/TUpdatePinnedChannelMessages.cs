// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8588878b)]
	public sealed class TUpdatePinnedChannelMessages : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       public int ChannelId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<int> Messages {get; set;}

       [SerializationOrder(4)]
       public int Pts {get; set;}

       [SerializationOrder(5)]
       public int PtsCount {get; set;}

	}
}
