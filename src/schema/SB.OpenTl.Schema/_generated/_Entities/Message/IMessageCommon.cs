// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageCommon : IObject
    {
       BitArray Flags {get; set;}

       bool Out {get; set;}

       bool Mentioned {get; set;}

       bool MediaUnread {get; set;}

       bool Silent {get; set;}

       bool Post {get; set;}

       bool Legacy {get; set;}

       int Id {get; set;}

       OpenTl.Schema.IPeer FromId {get; set;}

       OpenTl.Schema.IPeer PeerId {get; set;}

       OpenTl.Schema.IMessageReplyHeader ReplyTo {get; set;}

       int Date {get; set;}

    }
}
