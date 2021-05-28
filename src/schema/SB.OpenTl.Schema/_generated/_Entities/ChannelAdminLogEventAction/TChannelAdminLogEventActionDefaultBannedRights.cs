// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2df5fc0a)]
	public sealed class TChannelAdminLogEventActionDefaultBannedRights : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChatBannedRights PrevBannedRights {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChatBannedRights NewBannedRights {get; set;}

	}
}
