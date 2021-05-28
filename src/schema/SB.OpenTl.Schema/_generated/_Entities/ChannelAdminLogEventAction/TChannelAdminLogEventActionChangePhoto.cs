// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x434bd2af)]
	public sealed class TChannelAdminLogEventActionChangePhoto : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPhoto PrevPhoto {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPhoto NewPhoto {get; set;}

	}
}
