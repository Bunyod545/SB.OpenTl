// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xafeb712e)]
	public sealed class TInputChannel : IInputChannel
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

	}
}
