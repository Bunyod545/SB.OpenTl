// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageReplyHeader : IObject
    {
       BitArray Flags {get; set;}

       int ReplyToMsgId {get; set;}

       OpenTl.Schema.IPeer ReplyToPeerId {get; set;}

       int ReplyToTopId {get; set;}

    }
}
