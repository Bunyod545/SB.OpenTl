// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x53909779)]
	public sealed class TChannelAdminLogEventActionToggleSlowMode : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public int PrevValue {get; set;}

       [SerializationOrder(1)]
       public int NewValue {get; set;}

	}
}
