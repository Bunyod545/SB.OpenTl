// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6b76ae)]
	public sealed class TChannelAdminLogEventActionChangeLocation : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChannelLocation PrevValue {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChannelLocation NewValue {get; set;}

	}
}
