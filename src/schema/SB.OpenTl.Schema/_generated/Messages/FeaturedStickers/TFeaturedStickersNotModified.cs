// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc6dc0c66)]
	public sealed class TFeaturedStickersNotModified : IFeaturedStickers
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

	}
}
