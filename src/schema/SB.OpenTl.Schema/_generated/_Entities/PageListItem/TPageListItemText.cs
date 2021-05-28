// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb92fb6cd)]
	public sealed class TPageListItemText : IPageListItem
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

	}
}
