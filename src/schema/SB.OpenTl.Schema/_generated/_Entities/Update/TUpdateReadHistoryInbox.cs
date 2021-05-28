// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9c974fdf)]
	public sealed class TUpdateReadHistoryInbox : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int FolderId {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int MaxId {get; set;}

       [SerializationOrder(4)]
       public int StillUnreadCount {get; set;}

       [SerializationOrder(5)]
       public int Pts {get; set;}

       [SerializationOrder(6)]
       public int PtsCount {get; set;}

	}
}
