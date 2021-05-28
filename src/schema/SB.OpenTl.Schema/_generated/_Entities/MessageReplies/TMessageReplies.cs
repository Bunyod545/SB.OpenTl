// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4128faac)]
	public sealed class TMessageReplies : IMessageReplies
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Comments {get; set;}

       [SerializationOrder(2)]
       public int Replies {get; set;}

       [SerializationOrder(3)]
       public int RepliesPts {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPeer> RecentRepliers {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public int ChannelId {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public int MaxId {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 3)]
       public int ReadMaxId {get; set;}

	}
}
