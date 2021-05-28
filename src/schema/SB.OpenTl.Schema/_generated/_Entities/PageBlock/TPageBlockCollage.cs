// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x65a0fa4d)]
	public sealed class TPageBlockCollage : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Items {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPageCaption Caption {get; set;}

	}
}
