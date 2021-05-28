// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5fe7025b)]
    public sealed class RequestGetOldFeaturedStickers : IRequest<OpenTl.Schema.Messages.IFeaturedStickers>
    {
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Limit {get; set;}

       [SerializationOrder(2)]
       public int Hash {get; set;}

    }
}
