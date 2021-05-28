// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6e8a84df)]
	public sealed class TUpdateChannelMessageForwards : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public int Id {get; set;}

       [SerializationOrder(2)]
       public int Forwards {get; set;}

	}
}
