// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2caa4a42)]
    public sealed class RequestGetContactIDs : IRequest<OpenTl.Schema.TVector<int>>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
