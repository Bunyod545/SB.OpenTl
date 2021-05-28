// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IVotesList : IObject
    {
       BitArray Flags {get; set;}

       int Count {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessageUserVote> Votes {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       byte[] NextOffsetAsBinary {get; set;}
       string NextOffset {get; set;}

    }
}
