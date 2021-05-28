// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x40582bb2)]
    public sealed class RequestSetDiscussionGroup : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Broadcast {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputChannel Group {get; set;}

    }
}
