// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x42ff96ed)]
    public sealed class RequestRequestCall : IRequest<OpenTl.Schema.Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Video {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(3)]
       public int RandomId {get; set;}

       [SerializationOrder(4)]
       public byte[] GAHash {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

    }
}
