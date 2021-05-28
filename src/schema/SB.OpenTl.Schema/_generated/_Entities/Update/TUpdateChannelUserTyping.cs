// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xff2abe9f)]
	public sealed class TUpdateChannelUserTyping : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int ChannelId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int TopMsgId {get; set;}

       [SerializationOrder(3)]
       public int UserId {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.ISendMessageAction Action {get; set;}

	}
}
