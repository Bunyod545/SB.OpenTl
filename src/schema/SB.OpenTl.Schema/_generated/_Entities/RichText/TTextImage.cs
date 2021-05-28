// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x81ccf4f)]
	public sealed class TTextImage : IRichText
	{
       [SerializationOrder(0)]
       public long DocumentId {get; set;}

       [SerializationOrder(1)]
       public int W {get; set;}

       [SerializationOrder(2)]
       public int H {get; set;}

	}
}
