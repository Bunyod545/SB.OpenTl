// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x54c01850)]
	public sealed class TUpdateChatDefaultBannedRights : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChatBannedRights DefaultBannedRights {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

	}
}
