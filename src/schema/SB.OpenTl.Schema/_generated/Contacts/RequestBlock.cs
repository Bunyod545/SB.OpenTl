// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x68cc1411)]
    public sealed class RequestBlock : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Id {get; set;}

    }
}
