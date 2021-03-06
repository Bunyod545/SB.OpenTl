// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaca9fd2e)]
    public sealed class RequestInvokeWithTakeout : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public long TakeoutId {get; set;}

       [SerializationOrder(1)]
       public IObject Query {get; set;}

    }
}
