// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x42f88f2c)]
	public sealed class TUpdateMessagePollVote : IUpdate
	{
       [SerializationOrder(0)]
       public long PollId {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<byte[]> Options {get; set;}

	}
}
