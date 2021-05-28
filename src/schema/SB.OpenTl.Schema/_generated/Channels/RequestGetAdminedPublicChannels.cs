// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf8b036af)]
    public sealed class RequestGetAdminedPublicChannels : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ByLocation {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool CheckLimit {get; set;}

    }
}
