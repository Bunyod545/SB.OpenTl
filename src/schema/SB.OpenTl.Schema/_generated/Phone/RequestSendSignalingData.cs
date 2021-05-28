// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xff7a9383)]
    public sealed class RequestSendSignalingData : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] Data {get; set;}

    }
}
