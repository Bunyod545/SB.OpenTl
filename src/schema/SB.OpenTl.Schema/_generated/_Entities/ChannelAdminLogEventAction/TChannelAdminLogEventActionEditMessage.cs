// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x709b2405)]
	public sealed class TChannelAdminLogEventActionEditMessage : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IMessage PrevMessage {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IMessage NewMessage {get; set;}

	}
}
