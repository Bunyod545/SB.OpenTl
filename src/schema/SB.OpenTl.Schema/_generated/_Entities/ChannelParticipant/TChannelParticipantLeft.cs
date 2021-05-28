// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc3c6796b)]
	public sealed class TChannelParticipantLeft : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
