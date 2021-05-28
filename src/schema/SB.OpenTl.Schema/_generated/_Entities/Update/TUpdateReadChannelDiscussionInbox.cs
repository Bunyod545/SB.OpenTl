// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1cc7de54)]
	public sealed class TUpdateReadChannelDiscussionInbox : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int ChannelId {get; set;}

       [SerializationOrder(2)]
       public int TopMsgId {get; set;}

       [SerializationOrder(3)]
       public int ReadMaxId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public int BroadcastId {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public int BroadcastPost {get; set;}

	}
}
