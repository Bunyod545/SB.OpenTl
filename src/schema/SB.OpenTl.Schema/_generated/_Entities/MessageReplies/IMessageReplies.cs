// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageReplies : IObject
    {
       BitArray Flags {get; set;}

       bool Comments {get; set;}

       int Replies {get; set;}

       int RepliesPts {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPeer> RecentRepliers {get; set;}

       int ChannelId {get; set;}

       int MaxId {get; set;}

       int ReadMaxId {get; set;}

    }
}
