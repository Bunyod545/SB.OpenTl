// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x804361ea)]
	public sealed class TPageBlockAudio : IPageBlock
	{
       [SerializationOrder(0)]
       public long AudioId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPageCaption Caption {get; set;}

	}
}
