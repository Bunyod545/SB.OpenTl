﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa6d57763)]
	public sealed class TMessageReplyHeader : IMessageReplyHeader
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPeer ReplyToPeerId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int ReplyToTopId {get; set;}

	}
}
