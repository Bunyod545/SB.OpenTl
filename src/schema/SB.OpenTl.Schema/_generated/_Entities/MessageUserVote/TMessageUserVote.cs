// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa28e5559)]
	public sealed class TMessageUserVote : IMessageUserVote
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public byte[] Option {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
