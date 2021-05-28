// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2661bf09)]
	public sealed class TUpdatePhoneCallSignalingData : IUpdate
	{
       [SerializationOrder(0)]
       public long PhoneCallId {get; set;}

       [SerializationOrder(1)]
       public byte[] Data {get; set;}

	}
}
