// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc563c1e4)]
    public sealed class RequestUpdateDialogFiltersOrder : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Order {get; set;}

    }
}
