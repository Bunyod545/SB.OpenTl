// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe8fe0de)]
	public sealed class TMessageUserVoteMultiple : IMessageUserVote
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<byte[]> Options {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
