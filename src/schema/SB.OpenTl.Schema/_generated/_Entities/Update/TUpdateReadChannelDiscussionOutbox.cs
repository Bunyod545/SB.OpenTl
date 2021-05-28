// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4638a26c)]
	public sealed class TUpdateReadChannelDiscussionOutbox : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public int TopMsgId {get; set;}

       [SerializationOrder(2)]
       public int ReadMaxId {get; set;}

	}
}
