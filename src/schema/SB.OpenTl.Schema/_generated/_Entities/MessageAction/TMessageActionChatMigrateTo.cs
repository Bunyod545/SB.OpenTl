// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x51bdb021)]
	public sealed class TMessageActionChatMigrateTo : IMessageAction
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

	}
}
