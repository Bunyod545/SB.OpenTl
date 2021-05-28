// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1013fd9e)]
    public sealed class RequestDeleteByPhones : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<string> Phones {get; set;}

    }
}
