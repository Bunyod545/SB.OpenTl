// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa44f3ef6)]
	public sealed class TPageBlockMap : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       [SerializationOrder(1)]
       public int Zoom {get; set;}

       [SerializationOrder(2)]
       public int W {get; set;}

       [SerializationOrder(3)]
       public int H {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IPageCaption Caption {get; set;}

	}
}
