// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageViews : IObject
    {
       BitArray Flags {get; set;}

       int Views {get; set;}

       int Forwards {get; set;}

       OpenTl.Schema.IMessageReplies Replies {get; set;}

    }
}
