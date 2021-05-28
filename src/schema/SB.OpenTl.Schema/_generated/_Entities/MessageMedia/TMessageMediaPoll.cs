// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4bd6e798)]
	public sealed class TMessageMediaPoll : IMessageMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPoll Poll {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPollResults Results {get; set;}

	}
}
