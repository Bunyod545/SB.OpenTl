// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1e148390)]
	public sealed class TPageBlockKicker : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

	}
}
