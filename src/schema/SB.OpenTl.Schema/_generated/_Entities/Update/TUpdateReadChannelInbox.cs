// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x330b5424)]
	public sealed class TUpdateReadChannelInbox : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int FolderId {get; set;}

       [SerializationOrder(2)]
       public int ChannelId {get; set;}

       [SerializationOrder(3)]
       public int MaxId {get; set;}

       [SerializationOrder(4)]
       public int StillUnreadCount {get; set;}

       [SerializationOrder(5)]
       public int Pts {get; set;}

	}
}
